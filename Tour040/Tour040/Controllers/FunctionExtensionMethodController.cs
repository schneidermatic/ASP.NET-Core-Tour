using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using Tour040.Models;

namespace Tour040.Controllers
{
    public class FunctionExtensionMethodController : Controller
    {
        private readonly ILogger<FunctionExtensionMethodController> _logger;

        public FunctionExtensionMethodController(ILogger<FunctionExtensionMethodController> logger)
        {
            _logger = logger;
        }

        bool FilterByPrice(Product? p)
        {
            return (p?.Price ?? 0) >= 20;
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

            Func<Product?, bool> nameFilter = delegate (Product? prod)
            {
                return prod?.Name?[0] == 'S';
            };

            decimal priceFilterTotal = productArray
                .Filter(FilterByPrice)
                .TotalPrices2();
            decimal nameFilterTotal = productArray
                .Filter(nameFilter)
                .TotalPrices2();

            return View("Index", new string[] {
                    $"Price Total: {priceFilterTotal:C2}",
                    $"Name Total: {nameFilterTotal:C2}" });
        }
    }
}