using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Blazor.Models;
using Web.Blazor.Models.Session;

namespace Web.Blazor.Services
{
    public class SessionService : ISessionService
    {
        private readonly ApiClient _client;
        private readonly string _url;
        public abpResponse<GetCurrentLoginInformationsResult> response { get; set; }
        public GetCurrentLoginInformationsResult UserInfo { get; set; }
        public bool Finsished { get; set; }


        public SessionService(string url, ApiClient client)
        {
            _url = url;
            _client = client;
        }
        public async Task<abpResponse<GetCurrentLoginInformationsResult>> GetCurrentLoginInformationsAsync()
        {
            var Respone = await _client.GetAsync<abpResponse<GetCurrentLoginInformationsResult>>($"{_url}/api/services/app/Session/GetCurrentLoginInformations");

            return Respone;
        }

        public async Task init()
        {
            Finsished = false;
            this.response = await GetCurrentLoginInformationsAsync();
            if (response.result != null)
            {
                this.UserInfo = response.result;
                Console.WriteLine(UserInfo.tenant);
            }
            Finsished = true;

        }


    }
}
