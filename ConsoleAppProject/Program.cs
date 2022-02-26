using ConsoleAppProject;
using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
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
    /// Samuel Baker 26/02/2022
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine();
            Console.WriteLine(" ================================================= ");
            Console.WriteLine("    BNU CO453 Applications Programming 2021-2022!  ");
            Console.WriteLine("                  by Samuel Baker                  ");
            Console.WriteLine(" ================================================= ");
            Console.WriteLine();

            AppsList appChoice = SelectApp(" Please Choose which Application You would like to Use");

            RunApp();

            /// <summary>
            /// Prints a list of choices for the user to select from
            /// </summary>
            AppsList SelectApp(string prompt)
            {
                string[] choices =
                {
                $" {AppsList.DistanceConverter}",
                $" {AppsList.BMICalculator}"
            };

                Console.WriteLine(prompt);
                Console.WriteLine();
                int choice = ConsoleHelper.SelectChoice(choices);

                return ExecuteChoice(choice);
            }

            /// <summary>
            /// Executes the choice of unit based on the number inputted by the user
            /// </summary>
            static AppsList ExecuteChoice(int choice)
            {
                switch (choice)
                {
                    case 1: return AppsList.DistanceConverter; break;
                    case 2: return AppsList.BMICalculator; break;

                    default: return AppsList.NoApp;
                }
            }

            void RunApp()
            {
                if (appChoice.Equals(AppsList.DistanceConverter))
                {
                    DistanceConverter converter = new DistanceConverter();
                    converter.Run();
                }
                else if (appChoice.Equals(AppsList.BMICalculator))
                {
                    BMICalculator calculator = new BMICalculator();
                    calculator.Run();
                }
            }
        }
    }
}