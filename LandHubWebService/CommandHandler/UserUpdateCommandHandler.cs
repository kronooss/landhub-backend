﻿
using Commands;

using Domains.DBModels;

using MediatR;

using Services.Repository;

using System.Threading;
using System.Threading.Tasks;

namespace CommandHandler
{
    public class UserUpdateCommandHandler : AsyncRequestHandler<UserUpdateCommand>
    {
        private IBaseRepository<User> _userManager;

        public UserUpdateCommandHandler(IBaseRepository<User> userManager)
        {
            _userManager = userManager;
        }

        protected override async Task<bool> Handle(UserUpdateCommand request, CancellationToken cancellationToken)
        {
            var user = await _userManager.GetByIdAsync(request.Id);
            user.FirstName = request.FirstName;
            user.LastName = request.LastName;
            user.Address = request.Address;
            user.DOB = request.DOB;
            user.Salutation = request.Salutation;
            user.DisplayName = request.DisplayName;
            var result = await _userManager.UpdateAsync(user);
            return result;
        }
    }
}