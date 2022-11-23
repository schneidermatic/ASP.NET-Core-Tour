using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Tour035.Models;

namespace Tour035.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ViewResult Index()
        {
            Product[] products = Product.GetProducts();
            return View( products );
        }

    }
}