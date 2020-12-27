using System;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace MailPassValidation
{
    public class MailValidation
    {
        public static bool ValidateMail(string emailaddress)
        {
            try
            {
                MailAddress mail = new MailAddress(emailaddress);

                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(emailaddress);
                if (match.Success)
                {
                    return true;
                }
                return false;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
