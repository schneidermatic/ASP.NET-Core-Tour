using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Http.Headers;
using Tour040.Models;

namespace Tour040.Controllers
{
    public class ExtensionMethodController : Controller
    {
        private readonly ILogger<ExtensionMethodController> _logger;

        public ExtensionMethodController(ILogger<ExtensionMethodController> logger)
        {
            _logger = logger;
        }

        public ViewResult Index()
        {
            ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };
            decimal cartTotal = cart.TotalPrices();
            return View("Index", new string[] { $"Total: {cartTotal:C2}" });
        }
    }
}