using System.ComponentModel.DataAnnotations;
using SalesTrack.Model.Enums;

namespace SalesTrack.Model.InputModels;

public class ApplicationUserLoginInputModel
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
    public string Password { get; set; }

}