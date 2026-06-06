using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using SalesTrack.Model.InputModels;
using SalesTrack.Service.IService;

namespace SalesTrack.Api.Areas.Identity;

[Area("Identity")]
[DisplayName("Authentication Controller")]
[Route("api/[area]/[controller]")]
[ApiController]
public class AuthenticationController : ControllerBase
{
    private readonly IAuthenticationService _authenticationService;

    public AuthenticationController(IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
    }

    [HttpPost("login")]
    [DisplayName("Login")]
    public async Task<IActionResult> Login([FromBody] ApplicationUserLoginInputModel model)
    {
        var response = await _authenticationService.LoginAsync(model);
        return response.Success ? Ok(response) : BadRequest(response);
    }

    [HttpPost("register")]
    [DisplayName("Register")]
    public async Task<IActionResult> Register([FromBody] ApplicationUserRegisterInputModel model)
    {
        var response = await _authenticationService.RegisterAsync(model);
        return response ? Ok(response) : StatusCode(500);
    }

    [HttpPost("change-password")]
    [DisplayName("ChangePassword")]
    public async Task<IActionResult> ChangePassword([FromBody] ApplicationUserRegisterInputModel model)
    {
        var response = await _authenticationService.ChangePasswordAsync(model);
        return response ? Ok(response) : StatusCode(500);
    }

    [HttpPost("refresh-token")]
    [DisplayName("RefreshToken")]
    public async Task<IActionResult> RefreshToken([FromBody] ApplicationUserRegisterInputModel model)
    {
        var response = await _authenticationService.RefreshTokenAsync(model);
        return response ? Ok(response) : StatusCode(500);
    }

    [HttpPost("forgot-password")]
    [DisplayName("ForgotPassword")]
    public async Task<IActionResult> ForgotPassword([FromBody] ApplicationUserRegisterInputModel model)
    {
        var response = await _authenticationService.ForgotPasswordAsyn(model);
        return response ? Ok(response) : StatusCode(500);
    }

    [HttpPost("reset-password")]
    [DisplayName("ResetPassword")]
    public async Task<IActionResult> ResetPassword([FromBody] ApplicationUserRegisterInputModel model)
    {
        var response = await _authenticationService.ResetPasswordAsync(model);
        return response ? Ok(response) : StatusCode(500);
    }
}
