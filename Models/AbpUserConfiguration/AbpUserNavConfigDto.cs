using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Blazor.Models.AbpUserConfiguration
{
    public class AbpUserNavConfigDto
    {
        public Dictionary<string, UserMenu> Menus { get; set; }
    }
}
