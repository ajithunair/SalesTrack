using SalesTrack.Model.Enums;

namespace SalesTrack.Model.ViewModels;

public class ApplicationUserViewModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Gender Gender { get; set; }
    public DateTime BirthDate { get; set; }
    public DateTime RegistrationDate { get; set; }
    public bool Activity { get; set; }
    public short? VerificationCode { get; set; }
    public string? ImageName { get; set; }
}