using System.Threading.Tasks;
using Web.Blazor.Models;
using Web.Blazor.Models.TokenAuth;
using Web.Blazor.Models.TokenAuth.Results;

namespace Web.Blazor.Services
{
    public interface IAuthService
    {
        public Task<abpResponse<AuthenticateResult>> AuthenticateAsync(AuthenticateRequest request);

    }
}
