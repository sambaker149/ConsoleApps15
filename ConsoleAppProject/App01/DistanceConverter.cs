using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This App will prompt the user to input a distance
    /// measured in one unit (fromUnit) and it will calculate and
    /// output the equivalent distance in another unit (toUnit)
    /// </summary>
    /// <author>
    /// Samuel Baker 18/02/2022
    /// </author>
    public class DistanceConverter
    {
        public const int INCHES_IN_FEET = 12;
        public const int INCHES_IN_MILES = 63360;
        public const int CENTIMETRES_IN_METRES = 100;
        public const int CENTIMETRES_IN_KILOMETRES = 100000;
        public const int CENTIMETRES_IN_MILES = 160934;
        public const int FEET_IN_MILES = 5280;
        public const int METRES_IN_KILOMETRES = 1000;
        public const double INCHES_IN_CENTIMETRES = 0.393701;
        public const double INCHES_IN_METRES = 39.3701;
        public const double INCHES_IN_KILOMETRES = 39370.1;
        public const double CENTIMETRES_IN_FEET = 30.48;
        public const double FEET_IN_METRES = 3.28084;
        public const double FEET_IN_KILOMETRES = 3280.84;
        public const double METRES_IN_MILES = 1609.34;
        public const double MILES_IN_KILOMETRES = 0.621371;

        public const string INCHES = "Inches";
        public const string CENTIMETRES = "Centimetres";
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

            Console.WriteLine();
            Console.WriteLine(" Choose a Unit to Convert From");
            fromUnit = SelectUnit(" Please Select a Unit > ");

            Console.WriteLine();
            Console.WriteLine(" Choose a Unit to Convert To");
            toUnit = SelectUnit(" Please Select a Unit > ");
            
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
        /// Prompts the user to select a unit from a list of choices
        /// Executes the choice
        /// Prints out a message telling the user the chosen unit
        /// </summary>
        private string SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);

            string unit = ExecuteChoice(choice);
            Console.WriteLine($" You have chosen {unit}");
            return unit;
        }

        /// <summary>
        /// Prints a list of choices for the user to select from
        /// </summary>
        private static string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($" 1. {INCHES}");
            Console.WriteLine($" 2. {CENTIMETRES}");
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
        /// Executes the choice of unit based on the number inputted by the user
        /// </summary>
        private string ExecuteChoice(string choice)
        {
            if (choice.Equals("1"))
            {
                return INCHES;
            }
            else if (choice.Equals("2"))
            {
                return CENTIMETRES;
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
        /// Calculates distance using pre-set constant values based on chosen units
        /// </summary>
        private void CalculateDistance()
        {
            if (fromUnit == INCHES && toUnit == CENTIMETRES)
            {
                toDistance = fromDistance / INCHES_IN_CENTIMETRES;
            }
            else if (fromUnit == CENTIMETRES && toUnit == INCHES)
            {
                toDistance = fromDistance * INCHES_IN_CENTIMETRES;
            }
            else if (fromUnit == INCHES && toUnit == FEET)
            {
                toDistance = fromDistance / INCHES_IN_FEET;
            }
            else if (fromUnit == FEET && toUnit == INCHES)
            {
                toDistance = fromDistance * INCHES_IN_FEET;
            }
            else if (fromUnit == INCHES && toUnit == METRES)
            {
                toDistance = fromDistance / INCHES_IN_METRES;
            }
            else if (fromUnit == METRES && toUnit == INCHES)
            {
                toDistance = fromDistance * INCHES_IN_METRES;
            }
            else if (fromUnit == INCHES && toUnit == KILOMETRES)
            {
                toDistance = fromDistance / INCHES_IN_KILOMETRES;
            }
            else if (fromUnit == KILOMETRES && toUnit == INCHES)
            {
                toDistance = fromDistance * INCHES_IN_KILOMETRES;
            }
            else if (fromUnit == INCHES && toUnit == MILES)
            {
                toDistance = fromDistance / INCHES_IN_MILES;
            }
            else if (fromUnit == MILES && toUnit == INCHES)
            {
                toDistance = fromDistance * INCHES_IN_MILES;
            }
            else if (fromUnit == CENTIMETRES && toUnit == FEET)
            {
                toDistance = fromDistance / CENTIMETRES_IN_FEET;
            }
            else if (fromUnit == FEET && toUnit == CENTIMETRES)
            {
                toDistance = fromDistance * CENTIMETRES_IN_FEET;
            }
            else if (fromUnit == CENTIMETRES && toUnit == METRES)
            {
                toDistance = fromDistance / CENTIMETRES_IN_METRES;
            }
            else if (fromUnit == METRES && toUnit == CENTIMETRES)
            {
                toDistance = fromDistance * CENTIMETRES_IN_METRES;
            }
            else if (fromUnit == CENTIMETRES && toUnit == KILOMETRES)
            {
                toDistance = fromDistance / CENTIMETRES_IN_KILOMETRES;
            }
            else if (fromUnit == KILOMETRES && toUnit == CENTIMETRES)
            {
                toDistance = fromDistance * CENTIMETRES_IN_KILOMETRES;
            }
            else if (fromUnit == CENTIMETRES && toUnit == MILES)
            {
                toDistance = fromDistance / CENTIMETRES_IN_MILES;
            }
            else if (fromUnit == MILES && toUnit == CENTIMETRES)
            {
                toDistance = fromDistance * CENTIMETRES_IN_MILES;
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
            else if (fromUnit == FEET && toUnit == KILOMETRES)
            {
                toDistance = fromDistance / FEET_IN_KILOMETRES;
            }
            else if (fromUnit == KILOMETRES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_KILOMETRES;
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
            else if (fromUnit == MILES && toUnit == KILOMETRES)
            {
                toDistance = fromDistance / MILES_IN_KILOMETRES;
            }
            else if (fromUnit == KILOMETRES && toUnit == MILES)
            {
                toDistance = fromDistance * MILES_IN_KILOMETRES;
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