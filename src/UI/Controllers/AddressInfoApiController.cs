using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UMApplication.Application.AddressInfos.Queries;

namespace UMApplication.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressInfoApiController : BaseController
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]     
        public async Task<ActionResult<List<string>>> GetAllProvince()
        {
            return Ok(await Mediator.Send(new GetProvinceQuery()));
        }

        [HttpGet("district")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<string>>> GetAllDistrict(string province)
        {
            return Ok(await Mediator.Send(new GetDistrictQuery { Province = province }));
        }

        [HttpGet("subdistrict")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<string>>> GetAllSubDistrict(string province,string district)
        {
            return Ok(await Mediator.Send(new GetSubDistrictQuery { Province = province , District = district }));
        }
    }
}
