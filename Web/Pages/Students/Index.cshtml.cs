using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ConsoleAppProject.App03;
using Web.Data;
using System.Collections;

namespace W.Pages.Marking
{
    public class IndexModel : PageModel
    {
        private readonly Web.Data.WebContext _context;

        public IndexModel(Web.Data.WebContext context)
        {
            _context = context;
        }

        public Student Student { get; set; }
        public IList<Student> Students { get; set; }
        public static int[] Marks { get; set; }
        public static Grades[] GradeProfile { get; set; }

        public async Task OnGetAsync()
        {
            Students = await _context.Student.ToListAsync();

            Marks = new int[Students.Count()];
            GradeProfile = new Grades[5];

            for (int i = 0; i < Students.Count(); i++)
            {
                Grades grade = Students[i].Grades;
                Marks[i] = Students[i].Marks;
                GradeProfile[(int)grade - 1] = GradeProfile[(int)grade - 1] + 1;
            }
            return;
        }
    }
}