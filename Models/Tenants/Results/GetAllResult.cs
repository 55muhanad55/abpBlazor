
using System.Collections.Generic;

namespace Web.Blazor.Models.Tenants.Results
{
    public class GetAllResult
    {
        public int totalCount { get; set; }
        public List<TenantDto> items { get; set; }
    }
}
