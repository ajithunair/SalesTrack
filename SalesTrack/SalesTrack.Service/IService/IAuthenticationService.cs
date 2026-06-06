using System.Threading.Tasks.Dataflow;
using SalesTrack.Model.InputModels;

namespace SalesTrack.Service.IService;

public interface IAuthenticationService
{
    Task<bool> LoginAsync(ApplicationUserInputModel model);
    Task<bool> RegisterAsync(ApplicationUserInputModel model);
    Task<bool> ForgotPasswordAsyn(ApplicationUserInputModel model);
    Task<bool> ResetPasswordAsync(ApplicationUserInputModel model);
    Task<bool> ChangePasswordAsync(ApplicationUserInputModel model);
    Task<bool> RefreshTokenAsync(ApplicationUserInputModel model);
}