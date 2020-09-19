using System.ComponentModel.DataAnnotations;

namespace Web.Blazor.Models.Account
{
    public class RegisterRequest
    {
        [Required]
        [StringLength(64)]
        public string Name { get; set; }

        [Required]
        [StringLength(64)]
        public string Surname { get; set; }

        [Required]
        [StringLength(32)]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(256)]
        public string EmailAddress { get; set; }

        [Required]
        [StringLength(32)]
        public string Password { get; set; }
    }
}
