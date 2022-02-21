using System.ComponentModel.DataAnnotations;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// List of units used to measure weight
    /// </summary>
    public enum WeightUnits
    {
        [Display(Name = "No Unit")]
        NoUnit,
        Pounds,
        Kilograms
    }
}