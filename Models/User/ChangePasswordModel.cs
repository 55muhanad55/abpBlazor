
using System.ComponentModel.DataAnnotations;


namespace Web.Blazor.Models.User
{
    public class ChangePasswordModel
    {
        [Required]
        [StringLength(32, MinimumLength = 2)]
        public string currentPassword { get; set; }
        [Required]
        [StringLength(32, MinimumLength = 2)]
        public string newPassword { get; set; }
        [Required]
        [StringLength(32, MinimumLength = 2)]
        [Compare("newPassword")]
        public string confirmNewPassword { get; set; }
    }
}
