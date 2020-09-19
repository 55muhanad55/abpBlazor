using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Blazor.Models.TokenAuth.Results
{
    public class AuthenticateResult
    {
        public string accessToken { get; set; }
        public string encryptedAccessToken { get; set; }
        public int expireInSeconds { get; set; }
        public int userId { get; set; }

    }
}
