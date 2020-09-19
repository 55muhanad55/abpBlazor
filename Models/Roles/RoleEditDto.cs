using System.ComponentModel.DataAnnotations;


namespace Web.Blazor.Models.Roles
{
    public class RoleEditDto
    {
        [Required]
        [StringLength(32)]
        public string Name { get; set; }

        [Required]
        [StringLength(32)]
        public string DisplayName { get; set; }

        public string Description { get; set; }

        public bool IsStatic { get; set; }
    }
}