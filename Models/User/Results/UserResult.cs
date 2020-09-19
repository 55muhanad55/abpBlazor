using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Web.Blazor.Models.User.Results
{
    public class UserResult
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
        public string fullName { get; set; }
        public DateTime? lastLoginTime { get; set; }
        public DateTime? creationTime { get; set; }
        public List<string> RoleNames { get; set; }
        public int id { get; set; }

    }
}
