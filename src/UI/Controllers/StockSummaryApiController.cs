using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UMApplication.Application.V_StockSummary.Queries;


namespace UMApplication.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockSummaryApiController : BaseController
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IList<StockSummaryListVm>>> Get()
        {
            return Ok(await Mediator.Send(new GetStockSummaryListQuery()));
        }
    }
}
