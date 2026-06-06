using Microsoft.AspNetCore.Identity;
using SalesTrack.Model.IdentityModels;
using SalesTrack.Model.InputModels;
using SalesTrack.Service.IService;

namespace SalesTrack.Service;

public class AuthenticationService : IAuthenticationService
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    public AuthenticationService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }
    public async Task<bool> LoginAsync(ApplicationUserLoginInputModel model)
    {
        var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);
        return result.Succeeded ? true : throw new Exception("Unable to create user, Errors: " + result.ToString());
    }

    public async Task<bool> RegisterAsync(ApplicationUserRegisterInputModel model)
    {
        ArgumentNullException.ThrowIfNull(model.Email);
        ArgumentNullException.ThrowIfNull(model.Password);

        var user = new ApplicationUser
        {
            Email =  model.Email,
            UserName =  model.Email,
            FirstName =  model.FirstName,   
            LastName =  model.LastName,
            BirthDate = model.BirthDate,
            Gender = model.Gender,
            RegistrationDate = DateTime.UtcNow
        };
        var result = await _userManager.CreateAsync(user, model.Password);
        return result.Succeeded ? true : throw new Exception("Unable to create user, Errors: " + result.Errors);
    }

    public Task<bool> ForgotPasswordAsyn(ApplicationUserRegisterInputModel model)
    {
        throw new NotImplementedException();
    }

    public Task<bool> ResetPasswordAsync(ApplicationUserRegisterInputModel model)
    {
        throw new NotImplementedException();
    }

    public Task<bool> ChangePasswordAsync(ApplicationUserRegisterInputModel model)
    {
        throw new NotImplementedException();
    }

    public Task<bool> RefreshTokenAsync(ApplicationUserRegisterInputModel model)
    {
        throw new NotImplementedException();
    }
}