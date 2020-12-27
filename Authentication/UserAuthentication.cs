#define password
using MailPassValidation;
using System;

namespace Registration
{
    class UserRegistration
    {
        static void Main(string[] args)
        {
            GetMail();

            GetPassword();
        }
        #region Getting Mail and Pass *********************************************************************************************************
        public static void GetMail()
        {
            Console.WriteLine("Enter your eMail :");
            string mail = Console.ReadLine();
            ValidateMail(mail);
        }
        public static void GetPassword()
        {
            Console.WriteLine("Enter your password (strong pass > 8 chars, >1 Upper, >1 Lower, >1 digit, >1 symbol) :");
            string pass = Console.ReadLine();
            ValidatePassword(pass);
        }
        #endregion
        #region  Validate Mail and Pass  *******************************************************************************************************
        public static void ValidateMail(string mail)
        {
            if (mail != "")
            {
                if (MailValidation.ValidateMail(mail) == false)
                {
                    Console.WriteLine("Try to enter a VALID eMail!");
                    GetMail();
                }
            }
            else
            {
                GetMail();
            }
        }

        public static void ValidatePassword(string pass)
        {
            if (PasswordValidation.ValidatePassword(pass) == false)
            {
                Console.WriteLine("Try to enter a STRONG password!");
                GetPassword();
            }
            else
            {
                DisplayPassword(pass);
            }
        }
        #endregion
        #region Display Pass  *****************************************************************************************************************
#if (password)
#if DEBUG
        public static void DisplayPassword(string pass)
        {
            Console.WriteLine("Remember your password : {0}", pass);
            Console.ReadKey();
        }
#else
        public static void DisplayPassword(string pass)
        {
            Console.Write("Your password is strong enough :  ");
            foreach (char c in pass)
            {
                Console.Write("*");
            }

            Console.ReadKey();
        }
#endif
#else
        public static void DisplayMail(string mail)
        {
            Console.Write("This method must not be used yet!");
        }
#endif
        #endregion
    }
}
