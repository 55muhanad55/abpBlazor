using System.ComponentModel.DataAnnotations;


namespace Web.Blazor.Models.Tenants
{
    public class TenantDto
    {
        [Required]
        [StringLength(64)]
        [RegularExpression("^[a-zA-Z][a-zA-Z0-9_-]{1,}$")]
        public string TenancyName { get; set; }

        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        public bool IsActive { get; set; }

        public int Id { get; set; }
    }
}
