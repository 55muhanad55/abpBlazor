using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Blazor.Models;
using Web.Blazor.Models.AbpUserConfiguration;

namespace Web.Blazor.Services
{
    public class UserConfigurationService : IUserConfigurationService
    {
        private readonly string _url;
        private readonly ApiClient _client;

        public abpResponse<AbpUserConfigurationDto> response { get; set; }
        public AbpUserConfigurationDto info { get; set; }
        public Dictionary<string,string> l { get; set; }
        public bool Finsished { get; set; }

        public UserConfigurationService(string url, ApiClient client)
        {
            this._url = url;
            this._client = client;
        }

        public async Task<abpResponse<AbpUserConfigurationDto>> GetAll()
        {
            var Respone = await _client.GetAsync<abpResponse<AbpUserConfigurationDto>>($"{_url}/AbpUserConfiguration/GetAll");

            return Respone;
        }

        public async Task Init()
        {
            Finsished = false;
            this.response = await GetAll();
            this.info = this.response.result;
            this.l = this.response.result.Localization.Values["BP2"];
            Finsished = true;
        }
    }
}
