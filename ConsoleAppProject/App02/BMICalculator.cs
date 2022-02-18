using System;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// This App will prompt the user to input a distance
    /// measured in one unit (fromUnit) and it will calculate and
    /// output the equivalent distance in another unit (toUnit)
    /// </summary>
    /// <author>
    /// Samuel Baker 18/02/2022
    /// </author>
    public class BMICalculator
    {
        /// <summary>
        /// Output a heading
        /// Prompt user as  to what units they want to convert between 
        /// </summary>
        public BMICalculator()
        {
            OutputHeading();
        }

        public void CalculateBMI()
        {
        }

        /// <summary>
        /// Print the heading of the distance converter application
        /// </summary>
        private static void OutputHeading()
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine();
            Console.WriteLine(" =============================== ");
            Console.WriteLine("        BMI Calculator           ");
            Console.WriteLine("        by Samuel Baker          ");
            Console.WriteLine(" =============================== ");
        }
    }
}