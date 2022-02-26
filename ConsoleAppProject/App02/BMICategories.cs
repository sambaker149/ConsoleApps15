using System.ComponentModel.DataAnnotations;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// List of units used to measure weight
    /// </summary>
    public enum BMICategories
    {
        [Display(Name = "No Category")]
        NoCategory,
        Underweight,
        Normal,
        Overweight,
        Obese_ClassI,
        Obese_ClassII,
        Obese_ClassIII
    }
}