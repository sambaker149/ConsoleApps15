using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// At the moment this class just tests the
    /// Grades enumeration names and descriptions
    /// </summary>
    public class StudentGrades
    {
        public const int MIN_F = 0;
        public const int MIN_D = 40;
        public const int MIN_C = 50;
        public const int MIN_B = 60;
        public const int MIN_A = 70;
        public const int MAX = 100;

        public string[] Students { get; set; }
        public int[] Marks { get; set; }
        //public int[] GradeProfile { get; set; }
        public double Mean { get; set; }
        public int Minimum { get; set; }
        public int Maximum { get; set; } 

        public void Run()
        {
            Students = new string[]
            { 
                "Sam", 
                "Nicola",
                "Robert",
                "Esther",
                "Kai", 
                "Kelsey",
                "Ethan",
                "Amy",
                "Lewis",
                "Catherine"
            };

            Marks = new int[Students.Length];

            ConsoleHelper.OutputHeading("App03 - Student Marks");

            InputMarks();
            OutputGrades();
        }

        private void InputMarks()
        {
            Console.WriteLine(" Please enter a Mark for each Student");
            
            int index = 0;
            foreach (var student in Students)
            {
                int mark = (int)ConsoleHelper.InputNumber(
                    $" Enter {student}'s Mark > ", 0, 100);

                Marks[index] = mark;
                index++;
            };

            Console.WriteLine();
        }

        public Grades ConvertToGrade(int mark)
        {
            if (mark >= MIN_F && mark <= MIN_D - 1)
                return Grades.F;
            if (mark >= MIN_D && mark <= MIN_C - 1)
                return Grades.D;
            if (mark >= MIN_C && mark <= MIN_B - 1)
                return Grades.C;
            if (mark >= MIN_B && mark <= MIN_A - 1)
                return Grades.B;
            if (mark >= MIN_A && mark <= MAX)
                return Grades.A;

            else return Grades.X;
        }

        private void OutputGrades()
        {
            Console.WriteLine(" Results for each Student");

            for (int i = 0; i < 10; i++)
            {
                int mark = Marks[i];
                Grades grade = ConvertToGrade(mark);
                Console.WriteLine($" {Students[i]}'s Mark = {mark}, Grade = {grade}");
            }
        }
    }
}