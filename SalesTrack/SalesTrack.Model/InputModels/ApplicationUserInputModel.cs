using System.ComponentModel.DataAnnotations;
using SalesTrack.Model.Enums;

namespace SalesTrack.Model.InputModels;

public class ApplicationUserInputModel
{
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    public Gender Gender { get; set; }
    public DateTime BirthDate { get; set; }
    public string? ImageName { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
    public string Password { get; set; }
    [Required]
    [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
    public string ConfirmPassword { get; set; }
}