using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UMApplication.Application.Products.Queries;
using UMApplication.Application.Products.Queries.GetProductList;
using UMApplication.Application.Products.Queries.GetProductDetail;
using UMApplication.Application.Products.Commands.UpsertProduct;


namespace UMApplication.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductApiController : BaseController
    {
        [HttpGet("GetAll")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IList<ProductListVm>>> GetAll()
        {
            return Ok(await Mediator.Send(new GetProductsListQuery()));
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<ProductDto>> Get(int id)
        {
            return Ok(await Mediator.Send(new GetProductDetailQuery { Id = id }));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Create(UpsertProductCommand command)
        {
            var id = await Mediator.Send(command);

            return Ok(id);
        }

    }
}
