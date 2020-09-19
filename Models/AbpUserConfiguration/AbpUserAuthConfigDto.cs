
using System.Collections.Generic;


namespace Web.Blazor.Models.AbpUserConfiguration
{
    public class AbpUserAuthConfigDto
    {
        public Dictionary<string, string> AllPermissions { get; set; }

        public Dictionary<string, string> GrantedPermissions { get; set; }
    }
}
