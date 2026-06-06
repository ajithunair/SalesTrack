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

    [HttpPost]
    [DisplayName("Login")]
    public async Task<IActionResult> Login([FromBody] ApplicationUserInputModel model)
    {
        var response = await _authenticationService.LoginAsync(model);
        return Ok(response);
    }

    [HttpPost]
    [DisplayName("Register")]
    public async Task<IActionResult> Register([FromBody] ApplicationUserInputModel model)
    {
        var response = await _authenticationService.RegisterAsync(model);
        return Ok(response);
    }

    [HttpPost]
    [DisplayName("ChangePassword")]
    public async Task<IActionResult> ChangePassword([FromBody] ApplicationUserInputModel model)
    {
        var response = await _authenticationService.ChangePasswordAsync(model);
        return Ok(response);
    }

    [HttpPost]
    [DisplayName("RefreshToken")]
    public async Task<IActionResult> RefreshToken([FromBody] ApplicationUserInputModel model)
    {
        var response = await _authenticationService.RefreshTokenAsync(model);
        return Ok(response);
    }

    [HttpPost]
    [DisplayName("ForgotPassword")]
    public async Task<IActionResult> ForgotPassword([FromBody] ApplicationUserInputModel model)
    {
        var response = await _authenticationService.ForgotPasswordAsyn(model);
        return Ok(response);
    }

    [HttpPost]
    [DisplayName("ResetPassword")]
    public async Task<IActionResult> ResetPassword([FromBody] ApplicationUserInputModel model)
    {
        var response = await _authenticationService.ResetPasswordAsync(model);
        return Ok(response);
    }
}