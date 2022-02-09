using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UMApplication.Application.SalesOrderItems.Commands.InsertSalesOrderItem;


namespace UMApplication.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesOrderItemApiController : BaseController
    {
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Create(InsertSalesOrderItemCommand command)
        {
            var id = await Mediator.Send(command);

            return Ok(id);
        }

    }
}
