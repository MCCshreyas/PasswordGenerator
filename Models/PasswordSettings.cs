using System.ComponentModel.DataAnnotations;

namespace PasswordGenerator.Models
{
    public class PasswordSettings
    {
        [Display(Name = "Password length")] public int Length { get; set; }

        [Display(Name = "Include uppercase letters")]
        public bool UppercaseAllowed { get; set; }

        [Display(Name = "Include lowercase letters")]
        public bool LowercaseAllowed { get; set; }

        [Display(Name = "Include numbers")] public bool NumbersAllowed { get; set; }

        [Display(Name = "Include symbols")] public bool SymbolsAllowed { get; set; }
    }
}