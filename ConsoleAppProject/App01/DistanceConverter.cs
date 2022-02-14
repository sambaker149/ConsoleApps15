using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This App will prompt the user to input a distance
    /// measured in one unit (fromUnit) and it will calculate and
    /// output the equivalent distance in another unit (toUnit)
    /// </summary>
    /// <author>
    /// Samuel Baker 14/02/2022
    /// </author>
    public class DistanceConverter
    {
        public const int INCHES_IN_FEET = 12;
        public const int FEET_IN_MILES = 5280;
        public const int METRES_IN_KILOMETRES = 1000;
        public const double METRES_IN_MILES = 1609.34;
        public const double FEET_IN_METRES = 3.28084;
        public const double MILES_IN_KILOMETRES = 0.621371;

        public const string CENTIMETRES = "Centimetres";
        public const string INCHES = "Inches";
        public const string FEET = "Feet";
        public const string METRES = "Metres";
        public const string KILOMETRES = "Kilometres";
        public const string MILES = "Miles";

        private double fromDistance;
        private double toDistance;

        public string fromUnit;
        public string toUnit;

        /// <summary>
        /// Output a heading
        /// Prompt user as  to what units they want to convert between 
        /// </summary>
        public DistanceConverter()
        {
            OutputHeading();

            fromUnit = SelectUnit(" Please select the from Distance Unit > ");
            toUnit = SelectUnit(" Please select the to Distance Unit > ");
            
            Console.WriteLine();
            Console.WriteLine($" Converting {fromUnit} to {toUnit}");
            Console.WriteLine();
        }

        /// <summary>
        /// Ask for input for the distance in the initial unit
        /// Calculate and output the same distance in the second unit
        /// </summary>
        public void ConvertDistance()
        {
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

            string unit = ExecuteChoice(choice);
            Console.WriteLine($" You have chosen {unit}");
            return unit;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        private static string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($" 1. {CENTIMETRES}");
            Console.WriteLine($" 2. {INCHES}");
            Console.WriteLine($" 3. {FEET}");
            Console.WriteLine($" 4. {METRES}");
            Console.WriteLine($" 5. {KILOMETRES}");
            Console.WriteLine($" 6. {MILES}");
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
                return CENTIMETRES;
            }
            else if (choice.Equals("2"))
            {
                return INCHES;
            }
            if (choice.Equals("3"))
            {
                return FEET;
            }
            else if (choice.Equals("4"))
            {
                return METRES;
            }
            else if (choice.Equals("5"))
            {
                return KILOMETRES;
            }
            else if (choice.Equals("6"))
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
            if (fromUnit == INCHES && toUnit == FEET)
            {
                toDistance = fromDistance / INCHES_IN_FEET;
            }
            else if (fromUnit == FEET && toUnit == INCHES)
            {
                toDistance = fromDistance * INCHES_IN_FEET;
            }

            else if (fromUnit == FEET && toUnit == METRES)
            {
                toDistance = fromDistance / FEET_IN_METRES;
            }
            else if (fromUnit == METRES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_METRES;
            }
            else if (fromUnit == FEET && toUnit == MILES)
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }
            else if (fromUnit == MILES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }

            else if (fromUnit == METRES && toUnit == KILOMETRES)
            {
                toDistance = fromDistance / METRES_IN_KILOMETRES;
            }
            else if (fromUnit == KILOMETRES && toUnit == METRES)
            {
                toDistance = fromDistance * METRES_IN_KILOMETRES;
            }
            else if (fromUnit == METRES && toUnit == MILES)
            {
                toDistance = fromDistance / METRES_IN_MILES;
            }
            else if (fromUnit == MILES && toUnit == METRES)
            {
                toDistance = fromDistance * METRES_IN_MILES;
            }
        }

        /// <summary>
        /// Print out the result of the conversion from miles to metres
        /// </summary>
        private void OutputDistance()
        {
            Console.WriteLine();
            Console.WriteLine($" {fromDistance} {fromUnit} " +
                $"is {toDistance} {toUnit}");
        }

        /// <summary>
        /// Print the heading of the distance converter application
        /// </summary>
        private static void OutputHeading()
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine();
            Console.WriteLine(" =============================== ");
            Console.WriteLine("       Distance Converter        ");
            Console.WriteLine("        by Samuel Baker          ");
            Console.WriteLine(" =============================== ");
        }
    }
}