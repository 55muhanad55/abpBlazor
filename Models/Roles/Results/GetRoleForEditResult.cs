using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Blazor.Models.Roles.Results
{
    public class GetRoleForEditResult
    {
        public EditRoleDto role { get; set; }
        public List<PermissionDto> permissions { get; set; }
        public List<string> grantedPermissionNames { get; set; }

    }
}
