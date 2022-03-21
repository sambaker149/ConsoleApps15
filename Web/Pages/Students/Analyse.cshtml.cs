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
    public class AnalyseModel : PageModel
    {
        private readonly WebContext _context;

        public IList<Student> Students { get; set; }

        public StudentGrades App03 { get; set; }

        public AnalyseModel(WebContext context)
        {
            _context = context;
        }

        public async Task Index()
        {
            Students = await _context.Student.ToListAsync();
            int i = 0;
            foreach (Student student in Students)
            {
                App03.Students[i] = Students[i].Name;
                App03.Marks[i] = Students[i].Marks;
                i++;
            }
            App03.CalculateStatistics();
            App03.CalculateGradeProfile();
            return;
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            return Page();
        }
    }
}