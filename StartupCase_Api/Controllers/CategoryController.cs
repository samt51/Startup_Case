using Microsoft.AspNetCore.Mvc;
using StartupCase_Business.Abstract;

namespace StartupCase_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        public ICategoryService CategoryService;
        public CategoryController(ICategoryService categoryService)
        {
            CategoryService = categoryService;
        }
    }
}
