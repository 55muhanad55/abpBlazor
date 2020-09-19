using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Blazor.Models;
using Web.Blazor.Models.Account;
using Web.Blazor.Models.Account.Results;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Web.Blazor.Services
{
    public class AccountService : IAccountService
    {
        private readonly string _url;
        private readonly ApiClient _http;
        

        public AccountService(string url, ApiClient client)
        {
            _url = url;
            _http = client;
        }
        
        public async Task<abpResponse<IsTenantAvailableResult>> isTenantAvailableAsync(IsTenantAvailableRequest request)
        {
            var Response = await _http.PostAsync<abpResponse<IsTenantAvailableResult>>($"{_url}/api/services/app/Account/IsTenantAvailable", request);
            return Response;
        }

        

        public async Task<abpResponse<RegisterResult>> RegisterAsync(RegisterRequest request)
        {
            var Respone = await _http.PostAsync<abpResponse<RegisterResult>>($"{_url}/api/services/app/Account/Register", request);

            return Respone;
        }
    }
}
