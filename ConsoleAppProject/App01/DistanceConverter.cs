using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This App will prompt the user to input a distance
    /// measured in one unit (fromUnit) and it will calculate and
    /// output the equivalent distance in another unit (toUnit)
    /// </summary>
    /// <author>
    /// Samuel Baker 08/02/2022
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;

        public const double METRES_IN_MILES = 1609.34;

        public const double FEET_IN_METRES = 3.28084;

        public const string FEET = "Feet";
        public const string METRES = "Metres";
        public const string MILES = "Miles";

        private double fromDistance;
        private double toDistance;

        private string fromUnit;
        private string toUnit;  

        public DistanceConverter()
        {
            fromUnit = MILES;
            toUnit = FEET;
        }

        /// <summary>
        /// Output a heading
        /// Ask for input for miles 
        /// Calculate and output the same distance in feet
        /// </summary>
        public void ConvertDistance()
        {
            fromUnit = DisplayChoices(" Please select the from Distance Unit > ");
            toUnit = DisplayChoices(" Please select the to Distance Unit > ");

            OutputHeading($"Converting {fromUnit} to {toUnit}");

            fromDistance = InputDistance($" Please enter the Distance in {fromUnit} > ");

            CalculateDistance();

            OutputDistance();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        private string SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);

            return ExecuteChoice(choice);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        private static string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine(" 1. {FEET}");
            Console.WriteLine(" 2. {METRES}");
            Console.WriteLine(" 3. {MILES}");
            Console.WriteLine();

            Console.Write(prompt);
            string choice = Console.ReadLine();
            return choice;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="choice"></param>
        /// <returns></returns>
        private string ExecuteChoice(string choice)
        {
            if (choice.Equals("1"))
            {
                return FEET;
            }
            else if (choice.Equals("2"))
            {
                return METRES;
            }
            else if (choice.Equals("3"))
            {
                return MILES;
            }
            return null;
        }

        /// <summary>
        /// Prompt to user to input the distance in miles
        /// Input the miles as a double number
        /// </summary>
        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string number = Console.ReadLine();
            return Convert.ToDouble(number);
        }

        /// <summary>
        /// 
        /// </summary>
        private void CalculateDistance()
        {
            if (fromUnit == MILES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
            else if (fromUnit == FEET && toUnit == MILES)
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }
            else if (fromUnit == FEET && toUnit == MILES)
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }
        }

        /// <summary>
        /// Print out the result of the conversion from miles to metres
        /// </summary>
        private void OutputDistance()
        {
            Console.WriteLine($"{fromDistance} {fromUnit} " +
                $"is {toDistance} {toUnit}");
        }

        /// <summary>
        /// Print the heading of the distance converter application
        /// </summary>
        private static void OutputHeading(String prompt)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine();
            Console.WriteLine(" =============================== ");
            Console.WriteLine("       Distance Converter        ");
            Console.WriteLine("        by Samuel Baker          ");
            Console.WriteLine(" =============================== ");
            Console.WriteLine();
            Console.WriteLine(prompt);
            Console.WriteLine();
        }
    }
}