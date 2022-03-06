using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleAppProject.App02;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Pages
{
    public class BMICalculatorModel : PageModel
    {
        [BindProperty]
        public BMICalculator App02 { get; set; }

        public void OnGet()
        {
            ViewData["Message"] = "Please Enter Data";
        }

        public void OnPost()
        {
            App02.CalculateBMI();
            if (App02.UnitChoice.Equals(UnitChoices.Imperial))
            {
                App02.Inches = (App02.Feet * 12) + App02.Inches;
                App02.BMI = ((App02.Stones * 14) + App02.Pounds) * 703 / (App02.Inches * App02.Inches);
            }

            if (App02.UnitChoice.Equals(UnitChoices.Metric))
            {
                App02.Metres = App02.Centimetres / 100;
                App02.BMI = App02.Kilograms / (App02.Metres * App02.Metres);
            }

            ViewData["Message"] = $"Your BMI is {App02.BMI}. " +
                $"You are in the {App02.Category} Range";
        }
    }
}