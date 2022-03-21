#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ConsoleAppProject.App03;
using Web.Data;

namespace Web.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly WebContext _context;

        public Student Student { get; set; }
        public IList<Student> Students { get; set; }
        public StudentGrades App03 { get; set; }

        public IndexModel(WebContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            Students = await _context.Student.ToListAsync();
            for (int i = 0; i < Students.Count(); i++)
            {
                Grades grade = Students[i].Grades;
                App03.Marks[i] = Students[i].Marks;
                App03.GradeProfile[(int)grade - 1] = App03.GradeProfile[(int)grade - 1] + 1;
            }
            return;
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            return Page();
        }
    }
}