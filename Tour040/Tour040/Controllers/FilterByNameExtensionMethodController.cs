using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Http.Headers;
using Tour040.Models;

namespace Tour040.Controllers
{
    public class FilterByNameExtensionMethodController : Controller
    {
        private readonly ILogger<FilterByPriceExtensionMethodController> _logger;

        public FilterByNameExtensionMethodController(ILogger<FilterByPriceExtensionMethodController> logger)
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

            decimal priceFilterTotal = productArray.FilterByPrice(20).TotalPrices2();
            decimal nameFilterTotal = productArray.FilterByName('S').TotalPrices2();

            return View("Index", new string[] { 
                $"Total: {priceFilterTotal:C2}",
                $"Total: {nameFilterTotal:C2}" 
            });

        }

        
    }
}