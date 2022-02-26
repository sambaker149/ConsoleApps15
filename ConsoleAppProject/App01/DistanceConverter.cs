using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This App will prompt the user to input a distance
    /// measured in one unit (fromUnit) and it will calculate and
    /// output the equivalent distance in another unit (toUnit)
    /// </summary>
    /// <author>
    /// Samuel Baker 26/02/2022
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

        private double fromDistance;
        private double toDistance;

        private DistanceUnits fromUnit;
        private DistanceUnits toUnit;

        /// <summary>
        /// Output a heading
        /// Prompt user as  to what units they want to convert between 
        /// Ask for input for the distance in the initial unit
        /// Calculate and output the same distance in the second unit
        /// </summary>
        public void Run()
        {
            ConsoleHelper.OutputHeading("App01 - Distance Converter");

            fromUnit = SelectUnit(" Please Select a Unit to Convert From");
            Console.WriteLine($" You have chosen {fromUnit}");

            Console.WriteLine();
            toUnit = SelectUnit(" Please Select a Unit to Convert To");
            Console.WriteLine($" You have chosen {toUnit}");

            Console.WriteLine();
            Console.WriteLine($" Converting {fromUnit} to {toUnit}");
            Console.WriteLine();

            fromDistance = ConsoleHelper.InputNumber($" Please enter the Distance in {fromUnit} > ");

            CalculateDistance();

            OutputDistance();
        }

        /// <summary>
        /// Prints a list of choices for the user to select from
        /// </summary>
        private DistanceUnits SelectUnit(string prompt)
        {
            string[] choices =
            {
                $" {DistanceUnits.Inches}",
                $" {DistanceUnits.Centimetres}",
                $" {DistanceUnits.Feet}",
                $" {DistanceUnits.Metres}",
                $" {DistanceUnits.Kilometres}",
                $" {DistanceUnits.Miles}"
            };

            Console.WriteLine(prompt);
            Console.WriteLine();
            int choice = ConsoleHelper.SelectChoice(choices);

            return ExecuteChoice(choice);
        }

        /// <summary>
        /// Executes the choice of unit based on the number inputted by the user
        /// </summary>
        private static DistanceUnits ExecuteChoice(int choice)
        {
            switch (choice)
            {
                case 1: return DistanceUnits.Inches; break;
                case 2: return DistanceUnits.Centimetres; break;
                case 3: return DistanceUnits.Feet; break;
                case 4: return DistanceUnits.Metres; break;
                case 5: return DistanceUnits.Kilometres; break;
                case 6: return DistanceUnits.Miles; break;

                default: return DistanceUnits.NoUnit;
            }
        }

        /// <summary>
        /// Calculates distance using pre-set constant values based on chosen units
        /// </summary>
        private void CalculateDistance()
        {
            if (fromUnit == DistanceUnits.Inches &&
                toUnit == DistanceUnits.Centimetres)
            {
                toDistance = fromDistance / INCHES_IN_CENTIMETRES;
            }
            else if (fromUnit == DistanceUnits.Centimetres &&
                    toUnit == DistanceUnits.Inches)
            {
                toDistance = fromDistance * INCHES_IN_CENTIMETRES;
            }
            else if (fromUnit == DistanceUnits.Inches &&
                    toUnit == DistanceUnits.Feet)
            {
                toDistance = fromDistance / INCHES_IN_FEET;
            }
            else if (fromUnit == DistanceUnits.Feet &&
                    toUnit == DistanceUnits.Inches)
            {
                toDistance = fromDistance * INCHES_IN_FEET;
            }
            else if (fromUnit == DistanceUnits.Inches &&
                    toUnit == DistanceUnits.Metres)
            {
                toDistance = fromDistance / INCHES_IN_METRES;
            }
            else if (fromUnit == DistanceUnits.Metres &&
                    toUnit == DistanceUnits.Inches)
            {
                toDistance = fromDistance * INCHES_IN_METRES;
            }
            else if (fromUnit == DistanceUnits.Inches &&
                    toUnit == DistanceUnits.Kilometres)
            {
                toDistance = fromDistance / INCHES_IN_KILOMETRES;
            }
            else if (fromUnit == DistanceUnits.Kilometres &&
                    toUnit == DistanceUnits.Inches)
            {
                toDistance = fromDistance * INCHES_IN_KILOMETRES;
            }
            else if (fromUnit == DistanceUnits.Inches &&
                    toUnit == DistanceUnits.Miles)
            {
                toDistance = fromDistance / INCHES_IN_MILES;
            }
            else if (fromUnit == DistanceUnits.Miles &&
                    toUnit == DistanceUnits.Inches)
            {
                toDistance = fromDistance * INCHES_IN_MILES;
            }
            else if (fromUnit == DistanceUnits.Centimetres &&
                    toUnit == DistanceUnits.Feet)
            {
                toDistance = fromDistance / CENTIMETRES_IN_FEET;
            }
            else if (fromUnit == DistanceUnits.Feet &&
                    toUnit == DistanceUnits.Centimetres)
            {
                toDistance = fromDistance * CENTIMETRES_IN_FEET;
            }
            else if (fromUnit == DistanceUnits.Centimetres &&
                    toUnit == DistanceUnits.Metres)
            {
                toDistance = fromDistance / CENTIMETRES_IN_METRES;
            }
            else if (fromUnit == DistanceUnits.Metres &&
                    toUnit == DistanceUnits.Centimetres)
            {
                toDistance = fromDistance * CENTIMETRES_IN_METRES;
            }
            else if (fromUnit == DistanceUnits.Centimetres &&
                    toUnit == DistanceUnits.Kilometres)
            {
                toDistance = fromDistance / CENTIMETRES_IN_KILOMETRES;
            }
            else if (fromUnit == DistanceUnits.Kilometres &&
                    toUnit == DistanceUnits.Centimetres)
            {
                toDistance = fromDistance * CENTIMETRES_IN_KILOMETRES;
            }
            else if (fromUnit == DistanceUnits.Centimetres && toUnit == DistanceUnits.Miles)
            {
                toDistance = fromDistance / CENTIMETRES_IN_MILES;
            }
            else if (fromUnit == DistanceUnits.Miles &&
                    toUnit == DistanceUnits.Centimetres)
            {
                toDistance = fromDistance * CENTIMETRES_IN_MILES;
            }
            else if (fromUnit == DistanceUnits.Feet &&
                    toUnit == DistanceUnits.Metres)
            {
                toDistance = fromDistance / FEET_IN_METRES;
            }
            else if (fromUnit == DistanceUnits.Metres &&
                    toUnit == DistanceUnits.Feet)
            {
                toDistance = fromDistance * FEET_IN_METRES;
            }
            else if (fromUnit == DistanceUnits.Feet &&
                    toUnit == DistanceUnits.Miles)
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }
            else if (fromUnit == DistanceUnits.Miles &&
                    toUnit == DistanceUnits.Feet)
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
            else if (fromUnit == DistanceUnits.Feet &&
                    toUnit == DistanceUnits.Kilometres)
            {
                toDistance = fromDistance / FEET_IN_KILOMETRES;
            }
            else if (fromUnit == DistanceUnits.Kilometres &&
                    toUnit == DistanceUnits.Feet)
            {
                toDistance = fromDistance * FEET_IN_KILOMETRES;
            }
            else if (fromUnit == DistanceUnits.Metres &&
                    toUnit == DistanceUnits.Kilometres)
            {
                toDistance = fromDistance / METRES_IN_KILOMETRES;
            }
            else if (fromUnit == DistanceUnits.Kilometres &&
                    toUnit == DistanceUnits.Metres)
            {
                toDistance = fromDistance * METRES_IN_KILOMETRES;
            }
            else if (fromUnit == DistanceUnits.Metres &&
                    toUnit == DistanceUnits.Miles)
            {
                toDistance = fromDistance / METRES_IN_MILES;
            }
            else if (fromUnit == DistanceUnits.Miles &&
                    toUnit == DistanceUnits.Metres)
            {
                toDistance = fromDistance * METRES_IN_MILES;
            }
            else if (fromUnit == DistanceUnits.Miles &&
                    toUnit == DistanceUnits.Kilometres)
            {
                toDistance = fromDistance / MILES_IN_KILOMETRES;
            }
            else if (fromUnit == DistanceUnits.Kilometres &&
                    toUnit == DistanceUnits.Miles)
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
    }
}