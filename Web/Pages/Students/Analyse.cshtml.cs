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

        public AnalyseModel(WebContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return (IActionResult)await _context.Student.ToListAsync();
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            var students = await _context.Student.ToListAsync();
            StudentGrades grades = new StudentGrades();

            grades.Students = new string[students.Count];
            grades.Marks = new int[students.Count];

            int i = 0;

            foreach (Student student in students)
            {
                grades.Students[i] = student.Name;
                grades.Marks[i] = student.Marks;
                i++;
            }
            grades.CalculateStatistics();
            grades.CalculateGradeProfile();

            return Page();
        }
    }
}