using AspNetCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspNetCoreMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var student = new Student()
            {
                Name = "少司命",
                Age=18,
                Sex="女"
            };
            
            return View(student);
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