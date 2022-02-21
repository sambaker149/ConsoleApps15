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
    /// Samuel Baker 18/02/2022
    /// </author>
    public class BMICalculator
    {
        /// <summary>
        /// Output a heading
        /// Prompt user as  to what units they want to convert between 
        /// </summary>
        public void Run()
        {
            ConsoleHelper.OutputHeading("App02 - BMI Calculator");
        }

        public void CalculateBMI()
        {
        }
    }
}