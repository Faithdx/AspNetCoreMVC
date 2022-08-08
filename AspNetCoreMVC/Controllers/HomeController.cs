using AspNetCoreMVC.Models;
using AspNetCoreMVC.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspNetCoreMVC.Controllers
{
    //[Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string id)
        {
            var studentInfo = new StudentInfoViewModel();
            studentInfo.Title = "学生信息";
            studentInfo.Student = new Student()
            {
                Name = id,
                Age=18,
                Sex="女"
            };

            studentInfo.Address = new Address()
            {
                City = "天津",
                Region = "西青"
            };

            return View(studentInfo);
        }

        public IActionResult StudentInfos()
        {
            List<Student> students = new List<Student>();
            for (int i = 0; i < 30; i++)
            {
                students.Add(new Student()
                {
                    Id = i,
                    Name = "张三" + i.ToString(),
                    Age = 10+i,
                    Sex = i%2==0 ? "男" : "女"
                });
            }
            return View(students);
        }
        public IActionResult Details( int Id)
        {
            ViewBag.Id = Id;

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