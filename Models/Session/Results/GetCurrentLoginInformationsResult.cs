using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Blazor.Models.Session
{
    public class GetCurrentLoginInformationsResult
    {

        public user user { get; set; }
        public tenant tenant { get; set; }

    }
}
