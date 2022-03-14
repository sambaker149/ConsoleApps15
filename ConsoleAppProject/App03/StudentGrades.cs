using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// This App will prompt the user to input a grade
    /// for each student contained within a students array
    /// list and it will output the results and grade achieved
    /// for each student
    /// </summary>
    /// <author>
    /// Samuel Baker 08/03/2022
    /// </author>
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
        public int[] GradeProfile { get; set; }
        public double Mean { get; set; }
        public int Minimum { get; set; }
        public int Maximum { get; set; }

        /// <summary>
        /// Constructor called upon creation of an object
        /// Sets up array of students 
        /// </summary>
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

            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];

            OutputMenu();
        }

        public void OutputMenu()
        {
            string[] choices = 
            {
                " Input Marks",
                " Output Grades",
                " Output Statistics",
                " Output Grade Profile",
                " Quit" 
            };

            int choice;

            do
            {
                ConsoleHelper.OutputHeading("App03 - Student Marks");

                choice = ConsoleHelper.SelectChoice(choices);
                Console.WriteLine();

                switch (choice)
                {
                    case 1: 
                        InputMarks(); 
                        break;
                    case 2: 
                        OutputGrades(); 
                        break;
                    case 3:
                        CalculateStatistics(); 
                        break;
                    case 4:
                        CalculateGradeProfile();  
                        break;

                    default:
                        break;
                }

            } while (choice != 5);
        }

        /// <summary>
        /// Prompts the user to input marks for each student in
        /// the students array
        /// </summary>
        private void InputMarks()
        {
            Console.WriteLine(" Please enter a Mark for each Student");
            Console.WriteLine(" ------------------------------------");

            int i = 0;
            foreach (var student in Students)
            {
                int mark = (int)ConsoleHelper.InputNumber(
                    $" Enter {student}'s Mark > ", 0, 100);

                Marks[i] = mark;
                i++;
            };

            Console.WriteLine();
        }

        /// <summary>
        /// Converts the mark for each student, as inputted by the user,
        /// into a grade
        /// </summary>
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

        /// <summary>
        /// Outputs a list of the mark awarded to each student as well
        /// as the grade that they have achieved
        /// </summary>
        private void OutputGrades()
        {
            Console.WriteLine(" Results for each Student");
            Console.WriteLine(" ------------------------");

            for (int i = 0; i < 10; i++)
            {
                int mark = Marks[i];
                Grades grade = ConvertToGrade(mark);
                Console.WriteLine($" {Students[i]}'s Mark = {mark}, Grade = {grade}");
            }

            Console.WriteLine();
        }

        public void CalculateStatistics()
        {
            Minimum = Marks[0];
            Maximum = Marks[0];

            double total = 0;

            foreach(int mark in Marks)
            {
                if (mark > Maximum) Maximum = mark;
                if (mark < Minimum) Minimum = mark;

                total += mark;
            }

            Mean = total / Marks.Length;

            OutputStatistics();

            Console.WriteLine();
        }

        private void OutputStatistics()
        {
            Console.WriteLine(" Grade Statistics");
            Console.WriteLine(" ----------------");
            Console.WriteLine($" Minimum Mark is {Minimum}");
            Console.WriteLine($" Maximum Mark is {Maximum}");
            Console.WriteLine($" Mean Mark is {Mean}");
        }

        public void CalculateGradeProfile()
        {
            for (int i = 0; i < GradeProfile.Length; i++)
            {
                GradeProfile[i] = 0;
            }

            foreach (int mark in Marks)
            {
                Grades grade = ConvertToGrade(mark);
                GradeProfile[(int)grade]++;
            }

            OutputGradeProfile();
        }

        private void OutputGradeProfile()
        {
            Console.WriteLine(" Grade Profile");
            Console.WriteLine(" -------------");

            Grades grade = Grades.F;

            foreach (int count in GradeProfile)
            {
                int percentage = count * 100 / Marks.Length;
                Console.WriteLine($" Grade {grade}: Count {count} ({percentage}%)");
                grade++;
            }

            Console.WriteLine();
        }
    }
}