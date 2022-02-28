using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleAppProject.App01;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages
{
    public class DistanceConverterModel : PageModel
    {
        [BindProperty]
        public DistanceConverter App01 { get; set; } = new DistanceConverter();

        [BindProperty]
        public string Distance { get; set; }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            App01.fromDistance = Convert.ToDouble(Distance);
            App01.ConvertDistance();
        }
    }
}