using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Http.Headers;
using Tour040.Models;

namespace Tour040.Controllers
{
    public class PatternMatchingController : Controller
    {
        private readonly ILogger<PatternMatchingController> _logger;

        public PatternMatchingController(ILogger<PatternMatchingController> logger)
        {
            _logger = logger;
        }

        public ViewResult Index()
        {
            var data = new object[] { 275M, 29.95M, "apple", "orange", 100, 10 };
            decimal total = 0;

            for (int i = 0; i < data.Length; i++)
            {
                switch (data[i])
                {
                    case decimal decimalValue:
                        total += decimalValue;
                        break;
                    case int intValue when intValue > 50:
                        total += intValue;
                        break;
                }
            }

            return View("Index", new string[] { $"Total: {total:C2}" });
        }
    }
}