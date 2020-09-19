using System.ComponentModel.DataAnnotations;

namespace Web.Blazor.Models.User
{
    public class ResetPasswordDto
    {
        [Required]
        public string adminPassword { get; set; }
        public int userId { get; set; }
        [Required]
        [MaxLength(32)]
        public string newPassword { get; set; }


    }
}
