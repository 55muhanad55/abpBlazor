using System.Threading.Tasks;
using Web.Blazor.Models;
using Web.Blazor.Models.Session;

namespace Web.Blazor.Services
{
    public interface ISessionService
    {
        public abpResponse<GetCurrentLoginInformationsResult> response { get; set; }
        public GetCurrentLoginInformationsResult UserInfo { get; set; }
        public bool Finsished { get; set; }

        public Task<abpResponse<GetCurrentLoginInformationsResult>> GetCurrentLoginInformationsAsync();
        public Task init();
    }
}
