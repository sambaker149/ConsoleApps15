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
    /// Samuel Baker 21/02/2022
    /// </author>
    public class BMICalculator
    {
        private WeightUnits Weight;
        private HeightUnits Height;

        /// <summary>
        /// Output a heading
        /// Prompt user as  to what units they want to convert between 
        /// </summary>
        public void Run()
        {
            ConsoleHelper.OutputHeading("App02 - BMI Calculator");
        }

        /// <summary>
        /// Prints a list of choices for the user to select from
        /// </summary>
        private HeightUnits SelectHeightUnit(string prompt)
        {
            string[] choices =
            {
                $" {HeightUnits.Inches}",
                $" {HeightUnits.Metres}"
            };

            Console.WriteLine(prompt);
            Console.WriteLine();
            int choice = ConsoleHelper.SelectChoice(choices);

            return ExecuteHeightChoice(choice);
        }

        /// <summary>
        /// Executes the choice of unit of weight based on the number inputted by the user
        /// </summary>
        private static HeightUnits ExecuteHeightChoice(int choice)
        {
            switch (choice)
            {
                case 1: return HeightUnits.Inches; break;
                case 2: return HeightUnits.Metres; break;

                default: return HeightUnits.NoUnit;
            }
        }

        /// <summary>
        /// Prints a list of choices for the user to select from
        /// </summary>
        private WeightUnits SelectWeightUnit(string prompt)
        {
            string[] choices =
            {
                $" {WeightUnits.Pounds}",
                $" {WeightUnits.Kilograms}"
            };

            Console.WriteLine(prompt);
            Console.WriteLine();
            int choice = ConsoleHelper.SelectChoice(choices);

            return ExecuteWeightChoice(choice);
        }

        /// <summary>
        /// Executes the choice of unit of weight based on the number inputted by the user
        /// </summary>
        private static WeightUnits ExecuteWeightChoice(int choice)
        {
            switch (choice)
            {
                case 1: return WeightUnits.Pounds; break;
                case 2: return WeightUnits.Kilograms; break;

                default: return WeightUnits.NoUnit;
            }
        }

        public void CalculateBMI()
        {
        }
    }
}