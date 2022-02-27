using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// This App will prompt the user to input a distance
    /// measured in one unit (fromUnit) and it will calculate and
    /// output the equivalent distance in another unit (toUnit)
    /// </summary>
    /// <author>
    /// Samuel Baker 27/02/2022
    /// </author>
    public class BMICalculator
    {
        public const double BMI_UNDERWEIGHT = 18.5;
        public const double BMI_NORMAL = 18.5;
        public const int BMI_OVERWEIGHT = 25;
        public const int BMI_OBESE_I = 30;
        public const int BMI_OBESE_II = 35;
        public const int BMI_OBESE_III = 40;

        private double heightInFeet;
        private double heightInInches;
        private double heightInMetres;
        private double heightInCentimetres;
        private double weightInStones;
        private double weightInPounds;
        private double weightInKilograms;
        private double weightInGrams;

        private double userHeight;
        private double userWeight;

        private UnitChoices unitChoice;
        private BMICategories Category;

        private double BMI;

        /// <summary>
        /// Output a heading
        /// Prompt user as  to what units they want to convert between 
        /// </summary>
        public void Run()
        {
            ConsoleHelper.OutputHeading("App02 - BMI Calculator");

            OutputIntroduction();

            Console.WriteLine();
            unitChoice = SelectUnit(" Please Choose whether to use Imperial or Metric Units");
            Console.WriteLine($" You have chosen {unitChoice} Units");
            Console.WriteLine();

            InputMeasurement();

            CalculateBMI();

            OutputBMI();
        }

        /// <summary>
        /// Prompts the user to input their measurments based on their unit choice
        /// </summary>
        private void InputMeasurement()
        {
            if (unitChoice.Equals(UnitChoices.Imperial))
            {
                Console.WriteLine($" Please enter your Height in {UnitsList.Feet} and " +
                    $"{UnitsList.Inches}");
                heightInFeet = ConsoleHelper.InputNumber($" {UnitsList.Feet} > ");
                heightInInches = ConsoleHelper.InputNumber($" {UnitsList.Inches} > ");
                Console.WriteLine();
                Console.WriteLine($" Please enter your Weight in {UnitsList.Stones} and" +
                    $" {UnitsList.Pounds}");
                weightInStones = ConsoleHelper.InputNumber($" {UnitsList.Stones} > ");
                weightInPounds = ConsoleHelper.InputNumber($" {UnitsList.Pounds} > ");
            }

            if (unitChoice.Equals(UnitChoices.Metric))
            {
                Console.WriteLine($" Please enter your Height in {UnitsList.Metres} and " +
                    $"{UnitsList.Centimetres}");
                heightInMetres = ConsoleHelper.InputNumber($" {UnitsList.Metres} > ");
                heightInCentimetres = ConsoleHelper.InputNumber($" {UnitsList.Centimetres} > ");
                Console.WriteLine();
                Console.WriteLine($" Please enter your Weight in {UnitsList.Kilograms} and " +
                    $"{UnitsList.Grams}");
                weightInKilograms = ConsoleHelper.InputNumber($" {UnitsList.Kilograms} > ");
                weightInGrams = ConsoleHelper.InputNumber($" {UnitsList.Grams} > ");
            }
        }

        /// <summary>
        /// Outputs an introduction to the application
        /// </summary>
        private static void OutputIntroduction()
        {
            Console.WriteLine(" This Application is designed to calculate your BMI in " +
                "accordance with the World Health Organisation figures for BMI, as below");
            Console.WriteLine();
            Console.WriteLine($" Underweight = <{BMI_UNDERWEIGHT}");
            Console.WriteLine($" Normal = >{BMI_NORMAL}");
            Console.WriteLine($" Overweight = >{BMI_OVERWEIGHT}");
            Console.WriteLine($" Obese Class I = >{BMI_OBESE_I}");
            Console.WriteLine($" Obese Class II = >{BMI_OBESE_II}");
            Console.WriteLine($" Obese Class III = >{BMI_OBESE_III}");
            Console.WriteLine();
            Console.WriteLine(" All you need to use the Application is your height and weight" +
                "which you can input using Imperial or Metric Units");
            Console.WriteLine();
            Console.WriteLine(" Imperial Units are:");
            Console.WriteLine(" Height: Feet and Inches");
            Console.WriteLine(" Weight: Stones and Pounds");
            Console.WriteLine();
            Console.WriteLine(" Metric Units are:");
            Console.WriteLine(" Height: Metres and Centimetres");
            Console.WriteLine(" Weight: Kilograms and Grams");
        }

        /// <summary>
        /// Prints a list of choices for the user to select from
        /// </summary>
        private UnitChoices SelectUnit(string prompt)
        {
            string[] choices =
            {
                $" {UnitChoices.Imperial}",
                $" {UnitChoices.Metric}"
            };

            Console.WriteLine(prompt);
            Console.WriteLine();
            int choice = ConsoleHelper.SelectChoice(choices);

            return ExecuteChoice(choice);
        }

        /// <summary>
        /// Executes the choice of unit based on the number inputted 
        /// by the user
        /// </summary>
        private static UnitChoices ExecuteChoice(int choice)
        {
            switch (choice)
            {
                case 1: return UnitChoices.Imperial; break;
                case 2: return UnitChoices.Metric; break;

                default: return UnitChoices.NoUnit;
            }
        }

        /// <summary>
        /// Calculates the user's BMI using the appropriate formula 
        /// based on measurements given
        /// </summary>
        public void CalculateBMI()
        {
            if (unitChoice.Equals(UnitChoices.Imperial))
            {
                userHeight = (heightInFeet * 12) + heightInInches;
                userWeight = (weightInStones * 14) + weightInPounds;
                BMI = (userWeight * 703) / (userHeight * userHeight);
            }

            if (unitChoice.Equals(UnitChoices.Metric))
            {
                userHeight = (heightInMetres * 100) + heightInCentimetres;
                userWeight = (weightInKilograms * 1000) + weightInGrams;
                BMI = userWeight / (userHeight * userHeight);
            }

            CategoriseBMI();
        }

        /// <summary>
        /// Calculates the BMI category using the calculated BMI
        /// </summary>
        private void CategoriseBMI()
        {
            if (BMI < BMI_UNDERWEIGHT)
            {
                Category = BMICategories.Underweight;
            }
            else if (BMI >= BMI_NORMAL && BMI < BMI_OVERWEIGHT)
            {
                Category = BMICategories.Normal;
            }
            else if (BMI >= BMI_OVERWEIGHT && BMI < BMI_OBESE_I)
            {
                Category = BMICategories.Overweight;
            }
            else if (BMI >= BMI_OBESE_I && BMI < BMI_OBESE_II)
            {
                Category = BMICategories.Obese_ClassI;
            }
            else if (BMI >= BMI_OBESE_II && BMI < BMI_OBESE_III)
            {
                Category = BMICategories.Obese_ClassII;
            }
            else if (BMI >= BMI_OBESE_III)
            {
                Category = BMICategories.Obese_ClassIII;
            }
        }

        /// <summary>
        /// Print out the user's BMI and additional information
        /// </summary>
        private void OutputBMI()
        {
            Console.WriteLine();
            Console.WriteLine($" Your BMI is {BMI}. " +
                $"You are in the {Category} range");
        }
    }
}