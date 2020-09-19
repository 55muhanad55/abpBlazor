using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Blazor.Models.Account.Results
{
    public class IsTenantAvailableResult
    {
        public int state { get; set; }
        public int? tenantId { get; set; }
    }
}
