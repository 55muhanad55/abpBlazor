using System.ComponentModel.DataAnnotations;

namespace Web.Blazor.Models.Tenants
{
    public class CreateTenantDto
    {
        [Required]
        [StringLength(64)]
        [RegularExpression("^[a-zA-Z][a-zA-Z0-9_-]{1,}$")]
        public string tenancyName { get; set; }
        [Required]
        [StringLength(128)]
        public string name { get; set; }
        [Required]
        [StringLength(256)]
        public string adminEmailAddress { get; set; }
        [StringLength(1024)]
        public string connectionString { get; set; }

        public bool isActive { get; set; }


    }
}
