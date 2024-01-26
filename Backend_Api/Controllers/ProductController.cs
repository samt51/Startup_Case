using Backend_Business.Product.Model.Response;
using Backend_Business.Product.Queries.GetProductList;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Api.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly Mediator mediator;

        public ProductController(Mediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<List<GetProductListResponse>> GetProducts()
        {
            return await mediator.Send(new GetProductListQuery());
        }
    }
}
