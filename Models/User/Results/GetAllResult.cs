using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Blazor.Models.User.Results
{
    public class GetAllResult
    {
        public int totalCount { get; set; }
        public List<UserResult> items { get; set; }

    }
}
