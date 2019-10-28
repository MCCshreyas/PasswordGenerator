using System;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator.Models
{
    public static class PasswordGenerationHandler
    {
        private static readonly Random _random = new Random();

        public static Task<string> Generate(PasswordSettings settings)
        {
            var password = new StringBuilder();

            if (settings.LowercaseAllowed == false && settings.NumbersAllowed == false &&
                settings.SymbolsAllowed == false && settings.UppercaseAllowed == false)
                return Task.FromResult(string.Empty);

            for (var i = password.Length - 1; password.Length < settings.Length; i++)
            {
                if (settings.LowercaseAllowed) password.Append(GetRandomLowerCaseLetter());

                if (settings.UppercaseAllowed) password.Append(GetRandomUpperCaseLetter());

                if (settings.NumbersAllowed) password.Append(GetRandomNumber());

                if (settings.SymbolsAllowed) password.Append(GetRandomSpecialCharacter());
            }

            return Task.FromResult(password.ToString());
        }

        private static char GetRandomLowerCaseLetter()
        {
            var num = _random.Next(0, 26);
            var let = (char) ('a' + num);
            return let;
        }

        private static char GetRandomUpperCaseLetter()
        {
            var num = _random.Next(0, 26);
            var let = (char) ('A' + num);
            return let;
        }

        private static string GetRandomNumber()
        {
            var num = _random.Next();
            return num.ToString();
        }

        private static char GetRandomSpecialCharacter()
        {
            const string symbols = "!@#$%^&*(){}[]=<>/,.";

            return symbols[_random.Next(0, symbols.Length)];
        }
    }
}