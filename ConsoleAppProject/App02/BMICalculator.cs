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
    /// Samuel Baker 26/02/2022
    /// </author>
    public class BMICalculator
    {
        public const double BMI_UNDERWEIGHT = 18.49;
        public const double BMI_NORMAL = 18.5;
        public const int BMI_OVERWEIGHT = 25;
        public const int BMI_OBESE_I = 30;
        public const int BMI_OBESE_II = 35;
        public const int BMI_OBESE_III = 40;

        private double userHeight;
        private double userWeight;
        private double weight703;
        private double heightSquared;

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

            Console.WriteLine();
            unitChoice = SelectUnit(" Please Choose whether to use Imperial or Metric Units");
            Console.WriteLine($" You have chosen {unitChoice} Units");

            Console.WriteLine();
            Console.WriteLine($" Calculating using {unitChoice} Units");
            Console.WriteLine();

            if (unitChoice.Equals(UnitChoices.Imperial))
            {
                userHeight = ConsoleHelper.InputNumber($" Please enter your Height in {UnitsList.Feet} > ");
                userWeight = ConsoleHelper.InputNumber($" Please enter your Weight in {UnitsList.Stones} > ");
            }

            if (unitChoice.Equals(UnitChoices.Metric))
            {
                userHeight = ConsoleHelper.InputNumber($" Please enter your Height in {UnitsList.Metres} > ");
                userWeight = ConsoleHelper.InputNumber($" Please enter your Weight in {UnitsList.Kilograms} > ");
            }

            CalculateBMI();

            OutputBMI();
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
                heightSquared = userHeight * userHeight;
                weight703 = userWeight * 703;
                BMI = weight703 / heightSquared;
            }

            if (unitChoice.Equals(UnitChoices.Metric))
            {
                heightSquared = userHeight * userHeight;
                BMI = userWeight / heightSquared;
            }

            CategoriseBMI();
        }

        /// <summary>
        /// Calculates the BMI category using the calculated BMI
        /// </summary>
        private void CategoriseBMI()
        {
            if (BMI <= BMI_UNDERWEIGHT)
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