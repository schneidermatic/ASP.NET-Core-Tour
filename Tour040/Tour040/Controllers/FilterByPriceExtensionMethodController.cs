using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Http.Headers;
using Tour040.Models;

namespace Tour040.Controllers
{
    public class FilterByPriceExtensionMethodController : Controller
    {
        private readonly ILogger<FilterByPriceExtensionMethodController> _logger;

        public FilterByPriceExtensionMethodController(ILogger<FilterByPriceExtensionMethodController> logger)
        {
            _logger = logger;
        }

        public ViewResult Index()
        {
            ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };

            Product[] productArray =
            {
                new Product {Name = "Kayak", Price = 275M},
                new Product {Name = "lifejacket", Price = 48.95M},
                new Product {Name = "Soccer ball", Price = 19.50M},
                new Product {Name = "Corner flag", Price = 34.95M}
            };

            decimal arrayTotal = productArray.FilterByPrice(20).TotalPrices2();

            return View("Index", new string[] { $"Total: {arrayTotal:C2}" });
        }
    }
}