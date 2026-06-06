using System.Threading.Tasks.Dataflow;
using SalesTrack.Model.ApplicationModels;
using SalesTrack.Model.InputModels;

namespace SalesTrack.Service.IService;

public interface IAuthenticationService
{
    Task<ResponseModel<bool>> LoginAsync(ApplicationUserLoginInputModel model);
    Task<bool> RegisterAsync(ApplicationUserRegisterInputModel model);
    Task<bool> ForgotPasswordAsyn(ApplicationUserRegisterInputModel model);
    Task<bool> ResetPasswordAsync(ApplicationUserRegisterInputModel model);
    Task<bool> ChangePasswordAsync(ApplicationUserRegisterInputModel model);
    Task<bool> RefreshTokenAsync(ApplicationUserRegisterInputModel model);
}