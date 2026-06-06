using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using SalesTrack.Model.Enums;

namespace SalesTrack.Model.IdentityModels;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Gender Gender { get; set; }
    public DateTime BirthDate { get; set; }
    public DateTime RegistrationDate { get; set; }
    public bool Activity { get; set; }
    public short? VerificationCode { get; set; }
    public string? ImageName { get; set; }
    
    [NotMapped]
    public string? FullName => $"{FirstName} {LastName}";
}