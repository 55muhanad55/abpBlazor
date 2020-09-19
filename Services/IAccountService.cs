using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Blazor.Models;
using Web.Blazor.Models.Account.Results;
using Web.Blazor.Models.Account;
namespace Web.Blazor.Services
{
    interface IAccountService
    {
        public Task<abpResponse<IsTenantAvailableResult>> isTenantAvailableAsync(IsTenantAvailableRequest request);
        public Task<abpResponse<RegisterResult>> RegisterAsync(RegisterRequest request);
    }
}
