using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UMApplication.Application.SalesOrders.Commands.UpsertSalesOrder;
using UMApplication.Application.SalesOrders.Queries.GetSalesOrderList;
using UMApplication.Application.SalesOrders.Commands.UpdateStatusSalesOrder;
using UMApplication.Application.SalesOrders.Queries;
using UMApplication.Application.SalesOrders.Queries.GetSalesOrderDetail;
using UMApplication.Application.SalesOrderItems.Queries.GetListSalesOrderItemDetail;
using UMApplication.Application.SalesOrderItems.Queries;
using UMApplication.Application.SalesOrderItems.Commands.DeleteSalesOrderItem;

namespace UMApplication.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesOrderApiController : BaseController
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IList<SalesOrderListVm>>> GetAll()
        {
            return Ok(await Mediator.Send(new GetSalesOrdersListQuery()));
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<SalesOrderDto>> Get(int id)
        {
            return Ok(await Mediator.Send(new GetSalesOrderDetailQuery { Id = id }));
        }

        [HttpGet("GetListItems/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<SalesOrderItemListVm>> GetListItems(int id)
        {
            return Ok(await Mediator.Send(new GetListSalesOrderItemDetailQuery { SalesOrderId = id }));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Create(UpsertSalesOrderCommand command)
        {
            var id = await Mediator.Send(command);

            return Ok(id);
        }

        [HttpPost("EditStatus")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> EditStatus(UpdateStatusSalesOrderCommand command)
        {
            var id = await Mediator.Send(command);

            return Ok();
        }

        [HttpPost("DeleteItem")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> DeleteItem(DeleteSalesOrderItemCommand command)
        {
            var id = await Mediator.Send(command);

            return Ok();
        }

    }
}
