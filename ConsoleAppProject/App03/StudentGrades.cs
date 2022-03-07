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
            { "Sam", "Robert", "Kai", "Ethan"};
            Marks = new int[Students.Length];

            ConsoleHelper.OutputHeading("App03 - Student Marks");

            InputMarks();
            //ConvertToGrades();
            OutputGrades();
        }

        private void InputMarks()
        {
            Console.WriteLine(" Please enter a Mark for each Student");
            int Index = 0;

            foreach(string name in Students)
            {
                int mark = (int)ConsoleHelper.InputNumber($" Enter Mark for {name} > ");
                Marks[Index] = mark;
            }
        }

        public Grades ConvertToGrades(int mark)
        {
            if (mark >= MIN_F && mark <= (MIN_D - 1))
            {
                return Grades.F;
            }
            else if (mark >= MIN_D && mark <= (MIN_C - 1))
            {
                return Grades.D;
            }
            else if (mark >= MIN_C && mark <= (MIN_B - 1))
            {
                return Grades.C;
            }
            else if (mark >= MIN_B && mark <= (MIN_A - 1))
            {
                return Grades.B;
            }
            else if (mark >= MIN_A && mark <= MAX)
            {
                return Grades.A;
            }
            else return Grades.X;
        }

        private void OutputGrades()
        {
            for(int i = 0; i < Marks.Length; i++)
            {
                int mark = Marks[i];
                Grades grade = ConvertToGrades(mark);
                Console.WriteLine($" {Students[i]}'s Mark = {Marks[i]}, Grade = {grade}");
            }
        }
    }
}