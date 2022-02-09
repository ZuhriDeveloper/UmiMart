using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UMApplication.Application.Vouchers.Queries;
using UMApplication.Application.Vouchers.Queries.GetVoucherDetail;
using UMApplication.Application.Vouchers.Queries.GetVoucherList;
using UMApplication.Application.Vouchers.Commands.UpsertVoucher;

namespace UMApplication.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoucherApiController : BaseController
    {
        [HttpGet("GetAll")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IList<VoucherListVm>>> GetAll()
        {
            return Ok(await Mediator.Send(new GetVoucherListQuery()));
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<VoucherDto>> Get(int id)
        {
            return Ok(await Mediator.Send(new GetVoucherDetailQuery { Id = id }));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Save(UpsertVoucherCommand command)
        {
            var id = await Mediator.Send(command);

            return Ok(id);
        }
    }
}
