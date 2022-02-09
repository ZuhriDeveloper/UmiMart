using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UMApplication.Application.V_SalesSummaryPerItem.Queries;
using UMApplication.Application.V_SalesSummaryPerItem.Queries.GetSalesSummaryListPerItem;

namespace UMApplication.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesSummaryPerItemApiController : BaseController
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IList<SalesSummaryPerItemListVm>>> Get(DateTime dateFrom, DateTime dateTo,string filter)
        {
            return Ok(await Mediator.Send(new GetSalesSummaryListPerItemQuery { DateFrom = dateFrom, DateTo = dateTo, Filter = filter }));
        }
    }
}
