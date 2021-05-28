﻿using AutoMapper;

using Commands;

using Domains.DBModels;

using Infruscture;

using MediatR;

using PropertyHatchCoreService.IManagers;

using Services.IManagers;
using Services.Repository;

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CommandHandler
{
    public class CreateUserCommandHandler : AsyncRequestHandler<CreateUserCommand>
    {
        private IBaseUserManager _usermanager;
        private readonly IMapper _mapper;
        private IOrganizationManager _organizationManager;
        private IMappingService _mappingService;
        private IBaseRepository<Invitation> _baseRepositoryInvitation;
        private IBaseRepository<EmailTemplate> _baseRepositoryEmailTemplate;
        private IBaseRepository<Organization> _baseRepositoryOrganization;
        private IMailManager _mailManager;

        public CreateUserCommandHandler(IBaseUserManager userManager
            , IMapper mapper
            , IOrganizationManager organizationManager
            , IMappingService mappingService
            , IBaseRepository<Invitation> _baseRepositoryInvitation
            , IBaseRepository<EmailTemplate> _baseRepositoryEmailTemplate
            , IMailManager _mailManager
            , IBaseRepository<Organization> _baseRepositoryOrganization
            )
        {
            _usermanager = userManager;
            _mapper = mapper;
            _organizationManager = organizationManager;
            _mappingService = mappingService;
            this._baseRepositoryInvitation = _baseRepositoryInvitation;
            this._baseRepositoryEmailTemplate = _baseRepositoryEmailTemplate;
            this._mailManager = _mailManager;
            this._baseRepositoryOrganization = _baseRepositoryOrganization;
        }

        protected override async Task<bool> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            bool result = false;
            var orgId = Guid.NewGuid().ToString();
            var invitation = await _baseRepositoryInvitation.GetSingleAsync(x => x.InvitedUserEmail == request.Email);

            if (invitation == null)
            {
                var user = _mapper.Map<CreateUserCommand, ApplicationUser>(request);
                var userId = Guid.NewGuid().ToString();
                user.Id = userId;
                user.OrganizationId = orgId;

                var organization = new Organization
                {
                    CreatedBy = userId,
                    Id = orgId,
                    Title = request.OrganizationTitle,
                    Address = request.Address
                };

                result = await _usermanager.RegisterUserAsync(user, request.Password);

                if (result)
                {
                    await _organizationManager.CreateOrganizationAsync(organization);
                    await _mappingService.MapUserOrgRole(Const.DEFAULT_ADMIN_ROLE_ID, user.Id, organization.Id);

                    var rolePermissionMappingTemplate = await _mappingService.GetRolePermissionMappingTemplateById(Const.DEFAULT_ADMIN_ROLE_ID);
                    foreach (Permission permission in rolePermissionMappingTemplate.Permissions)
                    {
                        await _mappingService.MapRolePermissionByOrg(Const.DEFAULT_ADMIN_ROLE_ID, permission, orgId);
                    }
                    await _mappingService.MapOrgUser(userId, orgId);
                }
            }
            else
            {
                var user = _mapper.Map<CreateUserCommand, ApplicationUser>(request);
                var userId = Guid.NewGuid().ToString();
                orgId = invitation.OrgId;
                user.Id = userId;

                result = await _usermanager.RegisterUserAsync(user, request.Password);
                if (result)
                {
                    await _mappingService.MapUserOrgRole(Const.DEFAULT_USER_ROLE_ID, user.Id, orgId);

                    var rolePermissionMappingTemplate = await _mappingService.GetRolePermissionMappingTemplateById(Const.DEFAULT_USER_ROLE_ID);
                    foreach (Permission permission in rolePermissionMappingTemplate.Permissions)
                    {
                        await _mappingService.MapRolePermissionByOrg(Const.DEFAULT_USER_ROLE_ID, permission, orgId);
                    }
                    await _mappingService.MapOrgUser(userId, orgId);
                }
            }

            var org = await _baseRepositoryOrganization.GetSingleAsync(x => x.Id == orgId);

            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            keyValuePairs.Add("{@orgName}", org.Title);
            keyValuePairs.Add("{@senderName}", request.DisplayName);

            var template = await _baseRepositoryEmailTemplate.GetSingleAsync(x => x.TemplateName == Const.EMAIL_TEMPLATE_ACCOUNT_CREATION);
            string emailTemplate = _mailManager.EmailTemplate(template.TemplateBody, keyValuePairs);
            await _mailManager.SendEmail(new string[] { request.Email }, null, null, template.Subject, emailTemplate);

            return result;
        }
    }
}
