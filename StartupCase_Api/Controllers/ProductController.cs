using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StartupCase_Business.Abstract;
using StartupCase_Core.Dtos.ProductsDto.Response;

namespace StartupCase_Api.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public IProductService productService;
        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }
        [HttpGet]
        public List<ProductResponse> GetAll()
        {
            return this.productService.GetAll();
        }
    }
}
