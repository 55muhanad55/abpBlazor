using System.ComponentModel.DataAnnotations;

namespace Web.Blazor.Models.TokenAuth
{
    public class AuthenticateRequest
    {
        [Required]
        [StringLength(256)]
        public string userNameOrEmailAddress { get; set; }
        [Required]
        [StringLength(32)]
        public string password { get; set; }
        public bool rememberClient { get; set; }

    }
}
