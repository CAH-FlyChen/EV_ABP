using System.ComponentModel.DataAnnotations;

namespace EV.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}