using Microsoft.AspNetCore.Mvc;

namespace Frontend_UI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
