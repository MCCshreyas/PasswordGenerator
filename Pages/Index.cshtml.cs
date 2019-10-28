using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PasswordGenerator.Models;

namespace PasswordGenerator.Pages
{
    public class IndexModel : PageModel
    {
        public int MaxLength = 20;

        public int MinLength = 10;

        public string PasswordResult = string.Empty;

        [BindProperty] public PasswordSettings InputModel { get; set; }

        public void OnGet()
        {
            InputModel = new PasswordSettings
            {
                Length = MaxLength,
                UppercaseAllowed = true,
                SymbolsAllowed = true,
                LowercaseAllowed = true,
                NumbersAllowed = true
            };
        }

        public async void OnPostAsync()
        {
            PasswordResult = await PasswordGenerationHandler.Generate(InputModel);
        }
    }
}