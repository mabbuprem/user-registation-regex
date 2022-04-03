using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace User_Registration_Regex
{
    public class UserRegistrationPattern
    {
        public static string firstName = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public static string lastName = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public static string eMail = @"^[a-z]{3,}([.]{1}[a-z]{2,})?@bl.co([.]{1}[a-z]{2})?$";
        public static string mobileNoFormat = @"^91[ ][5-9]{1}[0-9]{9}$";
        public static string passwordFormat = "^(?=.*[!@#$%^&*])(?=.*[A-Z])(?=.*[0-9])[a-zA-Z1-9]{1}[a-zA-Z0-9]{7,}";
        public static string eMail2 = "^[a-z]{3,}(([.|+]{1})?([-]{1})?[0-9]{1,})?@[a-z0-9]{1,}.[a-z]{3}(.[a-z]{2,4})?$";
        public void ValidatePassword(string[] names)
        {
            foreach (string n in names)
            {
                string result = Regex.IsMatch(n, passwordFormat) ? $"{n} entered is valid" : $"{n} entered is Invalid";
                Console.WriteLine(result);
            }
        }
        public void ValidateMobileNo(string[] names)
        {
            foreach (string n in names)
            {
                string result = Regex.IsMatch(n, mobileNoFormat) ? $"{n} entered is valid" : $"{n} entered is Invalid";
                Console.WriteLine(result);
            }
        }
        public void ValidateeMail(string[] names)
        {
            foreach (string n in names)
            {
                string result = Regex.IsMatch(n, eMail2) ? $"{n} entered is valid" : $"{n} entered is Invalid";
                Console.WriteLine(result);
            }
        }
        public void ValidatelastName(string[] names)
        {
            foreach (string n in names)
            {
                string result = Regex.IsMatch(n, lastName) ? $"{n} entered is valid" : $"{n} entered is Invalid";
                Console.WriteLine(result);
            }
        }
        public void ValidateFirstName(string[] names)
        {
            foreach (string n in names)
            {
                string result = Regex.IsMatch(n, firstName) ? $"{n} entered is valid" : $"{n} entered is Invalid";
                Console.WriteLine(result);
            }
        }
    }
}