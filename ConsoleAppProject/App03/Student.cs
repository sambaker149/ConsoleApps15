using System;
using System.ComponentModel.DataAnnotations;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// This class is responsible for managing the Database 
    /// of the Web Version of the StudentMarks app
    /// Validates the data for user input.
    /// </summary>
    /// <author>
    /// Samuel Baker 22/03/2022
    /// </author>
    public class Student
    {
        public int ID { get; set; }

        [StringLength(20), Required]
        public string Name { get; set; }

        [Range(0, 100)]
        public int Mark { get; set; }

        public int Grade { get; set; }

        /// <summary>
        /// Converts the mark for each student, as inputted by the user,
        /// into a grade
        /// </summary>
        public void ConvertToGrade()
        {
            if (Mark >= StudentGrades.lowestF && Mark <= StudentGrades.lowestD - 1)
                Grade = (int)Grades.F;
            if (Mark >= StudentGrades.lowestD && Mark <= StudentGrades.lowestC - 1)
                Grade = (int)Grades.D;
            if (Mark >= StudentGrades.lowestC && Mark <= StudentGrades.lowestB - 1)
                Grade = (int)Grades.C;
            if (Mark >= StudentGrades.lowestB && Mark <= StudentGrades.lowestA - 1)
                Grade = (int)Grades.B;
            if (Mark >= StudentGrades.lowestA && Mark <= StudentGrades.maxMark)
                Grade = (int)Grades.A;

            else Grade = (int)Grades.X;
        }

    }
}