using Cloudcrate.AspNetCore.Blazor.Browser.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Blazor.Models;
using Web.Blazor.Models.TokenAuth;
using Web.Blazor.Models.TokenAuth.Results;

namespace Web.Blazor.Services
{
    public class AuthService : IAuthService
    {
        private readonly string _url;
        private readonly ApiClient _http;

        public AuthService(string url, ApiClient client)
        {
            _url = url;
            _http = client;
        }


        public async Task<abpResponse<AuthenticateResult>> AuthenticateAsync(AuthenticateRequest request)
        {
            var Respone = await _http.PostAsync<abpResponse<AuthenticateResult>>($"{_url}/api/TokenAuth/Authenticate", request);


            return Respone;
        }
    }
}
