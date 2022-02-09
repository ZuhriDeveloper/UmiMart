using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UMApplication.Application.V_SalesSummary.Queries;
using UMApplication.Application.V_SalesSummary.Queries.GetSalesSummaryListByDate;

namespace UMApplication.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesSummaryApiController : BaseController
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IList<SalesSummaryListVm>>> Get(DateTime dateFrom, DateTime dateTo)
        {
            return Ok(await Mediator.Send(new GetSalesSummaryListByDateQuery { DateFrom = dateFrom, DateTo = dateTo }));
        }
    }
}
