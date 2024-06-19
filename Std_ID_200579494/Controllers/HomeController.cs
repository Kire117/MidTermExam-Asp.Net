using Microsoft.AspNetCore.Mvc;
using Std_ID_200579494.Models;
using System.Diagnostics;

namespace Std_ID_200579494.Controllers
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
            Student student = new Student();
            student.StudentId = 200579494;
            student.FirstName = "Erick";
            student.LastName = "Ovando Perez";
            student.EmailAddress = "erick.ovando.ca@hotmail.com";


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
