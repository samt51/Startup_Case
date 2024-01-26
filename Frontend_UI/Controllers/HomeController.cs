using Frontend_UI.ClientConnection;
using Frontend_UI.Models;
using Frontend_UI.Models.Product.Model.Queries.GetProductList;
using Frontend_UI.Models.ProductFilter.Model.Queries.GetFilterAndValueByCategoryId;
using Frontend_UI.Models.ProductFilter.Model.Response;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Diagnostics;

namespace Frontend_UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMemoryCache _memoryCache;

        private readonly Mediator _mediator;
        public HomeController(Mediator _mediator, IMemoryCache memoryCache)
        {
            this._mediator = _mediator;
            _memoryCache = memoryCache;
        }
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> FilterByCategoryId(int categoryid)
        {
            string key = "productFilter";
            var data = new List<GetFilterAndValueByCategoryIdResponse>();
            //I am caching filter values
            if (!_memoryCache.TryGetValue(key, out data))
            {
                var cacheExpOptions = new MemoryCacheEntryOptions
                {
                    AbsoluteExpiration = DateTime.Now.AddMinutes(30),
                    Priority = CacheItemPriority.Normal
                };
                data = await _mediator.Send(new GetFilterAndValueByCategoryIdQuery(categoryid));
                _memoryCache.Set(key, data, cacheExpOptions);
            }
            return View(data);
        }

        public async Task<IActionResult> GetProduct()
        {
            var data = await _mediator.Send(new GetProductListQuery());
            return View(data);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
