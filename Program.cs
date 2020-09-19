using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Web.Blazor.Services;
using Cloudcrate.AspNetCore.Blazor.Browser.Storage;
using Radzen;
using Microsoft.AspNetCore.Components.Authorization;
namespace Web.Blazor
{
    public class Program
    {
        //private const string Url = "http://localhost:21021";
        private const string Url = "https://bp2webhost20200916032659.azurewebsites.net";


        public static async Task Main(string[] args)
        {

            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");
            builder.Services.AddScoped<NotificationService>();
            builder.Services.AddScoped<DialogService>();
            builder.Services.AddStorage();
            builder.Services.AddOptions();
            builder.Services.AddAuthorizationCore( 
                o => {
                    o.AddPolicy("Tenants", policy =>
                        policy.RequireClaim("Pages.Tenants"));

                    o.AddPolicy("Users", policy =>
                        policy.RequireClaim("Pages.Users"));

                    o.AddPolicy("Roles", policy =>
                        policy.RequireClaim("Pages.Roles"));
                });
            builder.Services.AddScoped<AuthenticationStateProvider, LocalAuthenticationStateProvider>();
            
            builder.Services.AddScoped<ApiClient>(s =>
            {
                return new ApiClient(s.GetRequiredService<LocalStorage>());
            });

            builder.Services.AddScoped<IAccountService,AccountService>(s =>
            {
                return new AccountService(Url, s.GetRequiredService<ApiClient>());
            });
            
            builder.Services.AddScoped<IAuthService,AuthService>(s =>
            {
                return new AuthService(Url, s.GetRequiredService<ApiClient>());
            });
            builder.Services.AddScoped<ISessionService, SessionService>(s =>
            {
                return new SessionService(Url, s.GetRequiredService<ApiClient>());
            });
            builder.Services.AddScoped<IUserConfigurationService, UserConfigurationService>(s =>
            {
                return new UserConfigurationService(Url, s.GetRequiredService<ApiClient>());
            });

            builder.Services.AddScoped<IRoleService, RoleService>(s =>
            {
                return new RoleService(Url, s.GetRequiredService<ApiClient>());
            });
            builder.Services.AddScoped<IUserService, UserService>(s =>
            {
                return new UserService(Url, s.GetRequiredService<ApiClient>());
            });
            builder.Services.AddScoped<ITenantService, TenantService>(s =>
            {
                return new TenantService(Url, s.GetRequiredService<ApiClient>());
            });


            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            await builder.Build().RunAsync();
        }
    }
}
