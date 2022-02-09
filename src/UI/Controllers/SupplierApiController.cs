using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UMApplication.Application.Suppliers.Queries;
using UMApplication.Application.Suppliers.Queries.GetSupplierList;
using UMApplication.Application.Suppliers.Queries.GetSupplierDetail;
using UMApplication.Application.Suppliers.Commands.UpsertSupplier;


namespace UMApplication.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierApiController : BaseController
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IList<SupplierListVm>>> GetAll()
        {
            return Ok(await Mediator.Send(new GetSuppliersListQuery()));
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<SupplierDto>> Get(int id)
        {
            return Ok(await Mediator.Send(new GetSupplierDetailQuery { Id = id }));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Create(UpsertSupplierCommand command)
        {
            var id = await Mediator.Send(command);

            return Ok(id);
        }

    }
}
