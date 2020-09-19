using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Blazor.Models;
using Web.Blazor.Models.AbpUserConfiguration;

namespace Web.Blazor.Services
{
    public interface IUserConfigurationService
    {
        public abpResponse<AbpUserConfigurationDto> response { get; set; }
        public AbpUserConfigurationDto info { get; set; }
        public bool Finsished { get; set; }
        public Dictionary<string, string> l { get; set; }

        public Task<abpResponse<AbpUserConfigurationDto>> GetAll ();
        public Task Init();
    }
}
