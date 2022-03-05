using ConsoleAppProject.App01;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Pages
{
    public class DistanceConverterModel : PageModel
    {
        [BindProperty]
        public DistanceConverter App01 { get; set; }

        // Set the html up
        public void OnGet()
        {
            ViewData["Message"] = "On Get Called";
        }

        // click on submit button
        public void OnPost()
        {
            App01.ConvertDistance();

            ViewData["Message"] = $"{App01.fromDistance} {App01.fromUnit} = " +
                $"{App01.toDistance.ToString("0.00")} {App01.toUnit}";
        }
    }
}