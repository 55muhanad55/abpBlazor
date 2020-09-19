using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Blazor.Models.Roles;

namespace Web.Blazor.Models.User.Results
{
    public class GetRolesResult
    {
        public List<RoleDto> items { get; set; }
    }
}
