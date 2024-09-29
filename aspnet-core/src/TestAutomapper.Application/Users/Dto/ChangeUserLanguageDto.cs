using System.ComponentModel.DataAnnotations;

namespace TestAutomapper.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}