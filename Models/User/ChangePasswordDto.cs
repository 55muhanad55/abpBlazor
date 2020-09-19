using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Blazor.Models.User
{
    public class ChangePasswordDto
    {
        [Required]
        [StringLength(32,MinimumLength =2)]
        public string currentPassword { get; set; }
        [Required]
        [StringLength(32, MinimumLength = 2)]
        public string newPassword { get; set; }
    }
}
