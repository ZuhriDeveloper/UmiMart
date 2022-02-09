using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UMApplication.Application.Members.Commands.UpSertMember;
using UMApplication.Application.Members.Queries.GetMembersList;
using UMApplication.Application.Members.Queries.GetMemberDetail;

namespace UMApplication.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberApiController : BaseController
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IList<MemberLookupDto>>> GetAll()
        {
            return Ok(await Mediator.Send(new GetMembersListQuery()));
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<MemberDetailVm>> Get(int id)
        {
            return Ok(await Mediator.Send(new GetMemberDetailQuery { Id = id }));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Create(UpSertMemberCommand command)
        {
            var id = await Mediator.Send(command);

            return Ok(id);
        }
    }
}
