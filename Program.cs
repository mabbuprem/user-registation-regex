using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace User_Registration_Regex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserRegistrationPattern userRegistrationPattern = new UserRegistrationPattern();
            string[] checkingFirstNames = { "Prem", "Pop", "Ho", "prem" };
            string[] checkingLastNames = { "Kumar", "khan", "So", "kumaran" };
            userRegistrationPattern.ValidateFirstName(checkingFirstNames);
            userRegistrationPattern.ValidatelastName(checkingLastNames);
        }
    }
}
