#nullable disable
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ConsoleAppProject.App03;

namespace Web.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly Web.Data.WebContext _context;

        public IndexModel(Web.Data.WebContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get; set; }
        public static int[] Marks { get; set; }
        public static int[] GradeProfile { get; set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Student.ToListAsync();

            Marks = new int[Student.Count()];
            GradeProfile = new int[5];

            for (int i = 0; i < Student.Count(); i++)
            {
                int grade = Student[i].Grade;
                Marks[i] = Student[i].Mark;
                GradeProfile[(int)grade] = GradeProfile[(int)grade] + 1;
            }
        }
    }
}