using Cloudcrate.AspNetCore.Blazor.Browser.Storage;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Web.Blazor.Services;

namespace Web.Blazor
{
    public class LocalAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly LocalStorage _localStorage;
        private readonly ApiClient _client;
        private readonly ISessionService _session;
        private readonly IUserConfigurationService _userConfiguration;

        public LocalAuthenticationStateProvider(LocalStorage localStorage, ApiClient client, ISessionService session, IUserConfigurationService userConfiguration)
        {
            this._localStorage = localStorage;
            this._client = client;
            this._session = session;
            this._userConfiguration = userConfiguration;
        }


        public async override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            await _session.init();
            if (_session.UserInfo.user != null)
            {
                var claims = new List<Claim>
                {
                    new Claim("emailAddress",_session.UserInfo.user.emailAddress),
                    new Claim("name",_session.UserInfo.user.name),
                    new Claim("surname",_session.UserInfo.user.surname),
                    new Claim("userName",_session.UserInfo.user.userName),
                    new Claim("Token",await _localStorage.GetItemAsync("Abp.AuthToken")),
                    new Claim(ClaimTypes.NameIdentifier, _session.UserInfo.user.id.ToString()),              
                };
                foreach (var item in _userConfiguration.info.Auth.GrantedPermissions)
                {
                    claims.Add(new Claim(item.Key, item.Value));
                }
                var identity = new ClaimsIdentity(claims, "BearerToken");
                var user = new ClaimsPrincipal(identity);
                var state = new AuthenticationState(user);
                //NotifyAuthenticationStateChanged(Task.FromResult(state));
                return state;
            }
            return new AuthenticationState(new ClaimsPrincipal());
        }
    }
    
}
