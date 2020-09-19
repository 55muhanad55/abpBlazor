using System.ComponentModel.DataAnnotations;

namespace Web.Blazor.Models.User
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}