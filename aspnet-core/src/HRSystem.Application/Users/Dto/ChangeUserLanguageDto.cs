using System.ComponentModel.DataAnnotations;

namespace HRSystem.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}