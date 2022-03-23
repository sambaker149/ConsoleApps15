#nullable disable
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Pages.Students
{
    public class AnalyseModel : PageModel
    {
        [BindProperty]
        public int Sum { get; set; }
        public double Mean { get; set; }
        public int Minimum { get; set; }
        public int Maximum { get; set; }
        public int F { get; set; }
        public int D { get; set; }
        public int C { get; set; }
        public int B { get; set; }
        public int A { get; set; }

        public void OnGet()
        {
            Mean = IndexModel.Marks.Average();
            Minimum = IndexModel.Marks.Min();
            Maximum = IndexModel.Marks.Max();

            A = (int)IndexModel.GradeProfile[0];
            B = (int)IndexModel.GradeProfile[1];
            C = (int)IndexModel.GradeProfile[2];
            D = (int)IndexModel.GradeProfile[3];
            F = (int)IndexModel.GradeProfile[4];
        }
    }
}