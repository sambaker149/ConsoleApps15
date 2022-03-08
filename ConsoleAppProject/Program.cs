﻿using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Samuel Baker 07/03/2022
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine();
            Console.WriteLine(" ================================================= ");
            Console.WriteLine("    BNU CO453 Applications Programming 2021-2022  ");                
            Console.WriteLine(" ================================================= ");
            Console.WriteLine();

            string[] choices =
            {
                " Distance Converter",
                " BMI Calculator",
                " Student Grades"
            };
        
            Console.WriteLine(" Please Choose which Application You would like to Use");
            Console.WriteLine();

            int choice = ConsoleHelper.SelectChoice(choices);

            switch (choice)
            {
                case 1:
                    DistanceConverter app01 = new DistanceConverter();
                    app01.Run();
                    break;
                case 2:
                    BMICalculator app02 = new BMICalculator();
                    app02.Run();
                    break;
                case 3:
                    StudentGrades app03 = new StudentGrades();
                    app03.Run();
                    break;

                default:
                    break;
                
            }
        }
    }
}