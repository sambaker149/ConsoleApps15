using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Allows the user to convert a distance in miles to feet
    /// </summary>
    /// <author>
    /// Samuel Baker 08/02/2022
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;

        private double miles;
        private double feet;
        private string number;

        /// <summary>
        /// Output a heading
        /// Ask for input for miles 
        /// Calculate and output the same distance in feet.
        /// </summary>
        public void Run()
        {
            OutputHeading();

            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        /// <summary>
        /// Print the heading of the distance converter application
        /// </summary>
        private static void OutputHeading()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine();
            Console.WriteLine(" =============================== ");
            Console.WriteLine("       Distance Converter        ");
            Console.WriteLine("        by Samuel Baker          ");
            Console.WriteLine(" =============================== ");
            Console.WriteLine();
        }

        /// <summary>
        /// Prompt to user to input the distance in miles
        /// Input the miles as a double number
        /// </summary>
        private void InputMiles()
        {
            Console.Write(" Please input the distance in miles to be converted > ");

            number = Console.ReadLine();
            miles = Convert.ToDouble(number);
        }

        /// <summary>
        /// Calculate the feet using the feet in miles conversion
        /// </summary>
        private void CalculateFeet()
        {
            feet = miles * FEET_IN_MILES;
        }

        /// <summary>
        /// Print out the result of the conversion
        /// </summary>
        private void OutputFeet()
        {
            Console.WriteLine("The number of miles = " + feet);
        }
    }
}