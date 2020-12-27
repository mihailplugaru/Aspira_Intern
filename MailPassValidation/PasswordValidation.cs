using System.Text.RegularExpressions;

namespace MailPassValidation
{
    public class PasswordValidation
    {
        public static bool ValidatePassword(string pass)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{8,8}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasLowerChar.IsMatch(pass))
            {
                return false;
            }
            else if (!hasUpperChar.IsMatch(pass))
            {
                return false;
            }
            else if (!hasMiniMaxChars.IsMatch(pass))
            {
                return false;
            }
            else if (!hasNumber.IsMatch(pass))
            {
                return false;
            }
            else if (!hasSymbols.IsMatch(pass))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
