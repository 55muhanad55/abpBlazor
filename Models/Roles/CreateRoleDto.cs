using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Web.Blazor.Models.Roles
{
    public class CreateRoleDto
    {
        [Required]
        [StringLength(32)]
        public string name { get; set; }

        [Required]
        [StringLength(32)]
        public string displayName { get; set; }

        public string normalizedName { get; set; }

        public string description { get; set; }

        public List<string> grantedPermissions { get; set; }

    }
}