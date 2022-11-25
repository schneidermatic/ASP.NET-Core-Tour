using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Http.Headers;
using Tour040.Models;

namespace Tour040.Controllers
{
    public class CollectionController : Controller
    {
        private readonly ILogger<CollectionController> _logger;

        public CollectionController(ILogger<CollectionController> logger)
        {
            _logger = logger;
        }

        public ViewResult Index()
        {
            return View("Index", new string[] { "Bob", "Joe", "Alice" });
        }
    }
}