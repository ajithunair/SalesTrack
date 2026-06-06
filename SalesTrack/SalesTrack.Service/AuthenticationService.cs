using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using SalesTrack.Model.IdentityModels;
using SalesTrack.Model.InputModels;
using SalesTrack.Service.IService;

namespace SalesTrack.Service;

public class AuthenticationService : IAuthenticationService
{
    private readonly UserManager<ApplicationUser> _userManager;
    public AuthenticationService(UserManager<ApplicationUser> userManager)
    {
        _userManager = userManager;
    }
    public Task<bool> LoginAsync(ApplicationUserInputModel model)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> RegisterAsync(ApplicationUserInputModel model)
    {
        ArgumentNullException.ThrowIfNull(model.Email);
        ArgumentNullException.ThrowIfNull(model.Password);

        var user = new ApplicationUser
        {
            Email =  model.Email,
            FirstName =  model.FirstName,   
            LastName =  model.LastName,
            BirthDate = model.BirthDate,
            Gender = model.Gender,
            RegistrationDate = DateTime.UtcNow
        };
        var result = await _userManager.CreateAsync(user, model.Password);
        if (result.Succeeded)
            return true;
        else
            throw new Exception("Unable to create user, Errors: " + result.Errors);
    }

    public Task<bool> ForgotPasswordAsyn(ApplicationUserInputModel model)
    {
        throw new NotImplementedException();
    }

    public Task<bool> ResetPasswordAsync(ApplicationUserInputModel model)
    {
        throw new NotImplementedException();
    }

    public Task<bool> ChangePasswordAsync(ApplicationUserInputModel model)
    {
        throw new NotImplementedException();
    }

    public Task<bool> RefreshTokenAsync(ApplicationUserInputModel model)
    {
        throw new NotImplementedException();
    }
}