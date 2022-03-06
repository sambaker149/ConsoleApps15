using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleAppProject.App01;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Pages
{
    public class DistanceConverterModel : PageModel
    {
        [BindProperty]
        public DistanceConverter App01 { get; set; }

        public void OnGet()
        {
            ViewData["Message"] = "Please Enter Data";
        }

        public void OnPost()
        {
            App01.CalculateDistance();

            ViewData["Message"] = $"{App01.FromDistance} {App01.FromUnit} is " +
                $"{App01.ToDistance.ToString("0.0")} {App01.ToUnit}";
        }
    }
}