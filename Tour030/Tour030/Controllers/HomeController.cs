using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Tour030.Controllers
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
            return View(new string[] { "C#", "Java", "Python" });
        }
    }
}