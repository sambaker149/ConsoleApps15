using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleAppProject.App01;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages
{
    public class DistanceConverterModel : PageModel
    {
        public DistanceConverter App01 { get; set; } = new DistanceConverter();

        [BindProperty]

        public string Distance
        public void OnGet()
        {
        }

        public void OnPost()
        {
            App01.fromDistance = Convert.ToDouble(Distance);
            App01.CalculateDistance();
        }
    }
}
