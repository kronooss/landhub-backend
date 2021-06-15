﻿
using Commands;
using Commands.Query;

using MediatR;

using Microsoft.AspNetCore.Mvc;

using System.Threading.Tasks;

namespace PropertyHatchWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ListingController : BaseController
    {
        private readonly IMediator _mediator;
        public ListingController(IMediator _mediator)
        {
            this._mediator = _mediator;
        }

        [HttpGet("[action]")]
        public async Task<ActionResult> GetAll(string orgId)
        {
            var getAllListingQuery = new GetAllListingQuery
            {
                OrgId = orgId
            };

            var result = await _mediator.Send(getAllListingQuery);
            return Ok(result);
        }

        [HttpGet("[action]")]
        public async Task<ActionResult> GetById(string listingId)
        {
            var getListingQuery = new GetListingQuery
            {
                ListingId = listingId ?? "1"
            };

            var result = await _mediator.Send(getListingQuery);
            return Ok(result);
        }

        [HttpPost("[action]")]
        public async Task<ActionResult> Add([FromBody] CreateListingCommand createListingCommand)
        {/*
            createListingCommand.OrganizationId = SecurityContext.OrgId;*/
            await _mediator.Send(createListingCommand);
            return Ok();
        }

        [HttpPost("[action]")]
        public async Task<ActionResult> Update([FromBody] UpdateListingCommand updateListingCommand)
        {
            await _mediator.Send(updateListingCommand);
            return Ok();
        }


        [HttpPost("[action]")]
        public async Task<ActionResult> Delete([FromBody] DeleteListingCommand deleteListingCommand)
        {
            await _mediator.Send(deleteListingCommand);
            return Ok();
        }

    }
}