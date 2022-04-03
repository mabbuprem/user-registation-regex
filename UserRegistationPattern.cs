using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace User_Registration_Regex
{
    internal class UserRegistrationPattern
    {
        public static string firstName = "^[A-Z]{1}[a-zA-Z]{2,}$";
     
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
