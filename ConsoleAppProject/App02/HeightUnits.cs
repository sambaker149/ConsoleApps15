using System.ComponentModel.DataAnnotations;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// List of units used to measure weight
    /// </summary>
    public enum HeightUnits
    {
        [Display(Name = "No Unit")]
        NoUnit,
        Inches,
        Metres
    }
}