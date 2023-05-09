using System.ComponentModel.DataAnnotations;

namespace DojoSurvey_Validations.Models;
#pragma warning disable CS8618

public class Student
{
    [Required(ErrorMessage = "is required.")]
    [MinLength(2)]
    public string Name { get; set; }

    [Required(ErrorMessage = "is required.")]
    public string Location { get; set; }

    [Required(ErrorMessage = "is required.")]
    public string Language { get; set; }

    [StringLength(255, MinimumLength = 20, ErrorMessage = "Should be more than 20 characters.")]
    public string? Comment { get; set; }


}