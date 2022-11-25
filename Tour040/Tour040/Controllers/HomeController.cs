using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Http.Headers;
using Tour040.Models;

namespace Tour040.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<CollectionController> _logger;

        public HomeController(ILogger<CollectionController> logger)
        {
            _logger = logger;
        }

        public ViewResult Index()
        {
            return View("Index", new string[] { "Bob", "Joe", "Alice" });
        }
    }
}