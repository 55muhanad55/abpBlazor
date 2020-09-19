using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Blazor.Models
{
    public class abpResponse<TResult>
    {
        public TResult result { get; set; }
        public string targetUrl { get; set; }
        public bool success { get; set; }
        public ResponseError error { get; set; }
        public bool unAuthorizedRequest { get; set; }
        public bool __abp { get; set; }
    }
}
