using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Blazor.Models.Roles
{
    public class PermissionsDialog
    {
        public string DisplayName { get; set; }
        public string Name { get; set; }

        public bool Granted { get; set; }

    }
}
