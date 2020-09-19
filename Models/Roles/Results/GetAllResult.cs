using System.Collections.Generic;

namespace Web.Blazor.Models.Roles.Results
{
    public class GetAllResult
    {
        public int totalCount { get; set; }
        public List<RoleDto> items { get; set; }

    }
}
