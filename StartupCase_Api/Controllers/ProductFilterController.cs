using Microsoft.AspNetCore.Mvc;
using StartupCase_Business.Abstract;
using StartupCase_Core.Dtos.ProductFilterDto.Response;

namespace StartupCase_Api.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class ProductFilterController : ControllerBase
    {
        private readonly IProductFilterService _filterService;

        public ProductFilterController(IProductFilterService filterService)
        {
            _filterService = filterService;
        }
        [HttpGet("{categoryid}")]
        public List<ProductFilterResponse> GetFilterAndValueByCategoryId(int categoryid)
        {
            return _filterService.GetFilterAndValueByCategoryId(categoryid);
        }
    }
}
