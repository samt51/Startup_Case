using Backend_Business.ProductFilter.Model.Response;
using Backend_Business.ProductFilter.Queries.GetFilterAndValueByCategoryId;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductFilterController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductFilterController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("{categoryid}")]
        public async Task<List<GetFilterAndValueByCategoryIdResponse>> getFilterAndValueByCategoryIdResponses(int categoryid)
        {
            var data = await _mediator.Send(new GetFilterAndValueByCategoryIdQuery(categoryid));

            return data;

        }
    }
}
