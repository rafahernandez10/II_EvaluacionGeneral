using Evaluacion2.Builder;
using Evaluacion2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace Evaluacion2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DatabaseConfiguration _dbConfig;

        public HomeController(ILogger<HomeController> logger, DatabaseConfiguration dbConfig)
        {
            _logger = logger;
            _dbConfig = dbConfig;
        }

        public IActionResult Index()
        {
            ViewBag.DatabaseType = _dbConfig.DatabaseType;
            ViewBag.ConnectionString = _dbConfig.ConnectionString;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
