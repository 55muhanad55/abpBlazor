using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Web.Blazor.Models.User
{
    public class CreateUserDto
    {
        [Required]
        [StringLength(32)]
        public string userName { get; set; }

        [Required]
        [StringLength(32)]
        public string name { get; set; }

        [Required]
        [StringLength(32)]
        public string surname { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(256)]
        public string emailAddress { get; set; }

        public bool isActive { get; set; }

        public List<string> roleNames { get; set; }

        [Required]
        [StringLength(32)]
        public string password { get; set; }
    }
}
