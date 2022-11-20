using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Tour010.Models;

namespace Tour010.Controllers
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
            _logger.LogInformation("==> Test Log Message");
            return View("MyView");
        }

    }
}