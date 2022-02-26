using System.ComponentModel.DataAnnotations;

namespace ConsoleAppProject
{
    /// <summary>
    /// List of units used to measure distance
    /// </summary>
    public enum AppsList
    {
        [Display(Name = "No Unit")]
        NoApp,
        DistanceConverter,
        BMICalculator
    }
}