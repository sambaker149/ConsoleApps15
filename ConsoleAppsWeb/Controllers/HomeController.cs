using ConsoleAppsWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ConsoleAppProject.App02;

namespace ConsoleAppsWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DistanceConverter()
        {
            return View();
        }

        [HttpGet]
        public IActionResult BMICalculator()
        {
            return View();
        }

        [HttpPost]
        public IActionResult BMICalculator(BMICalculator calculator)
        {
            if (calculator.Centimetres > 140)
            {
                calculator.CalculateBMI();
            }
            else if (calculator.Feet > 4 && calculator.Stones > 6)
            {
                calculator.CalculateBMI();
            }
            else
            {
                ViewBag.Error("You have entered values too small for any adult");
            }

            double BMI = BMI.Index;
            return RedirectToAction("OutputBMI", new {BMI});
        }

        public IActionResult OutputBMI()
        {
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