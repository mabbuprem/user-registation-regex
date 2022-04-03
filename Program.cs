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
            string[] checkingLastNames = { "Kumar", "khan", "So", "kumar" };
            string[] checkingEMails = { "abc@bl.co", "abc.xyz@bl.co", "abc.xyz@bl.co.in", "abc.@bl.co" };
            string[] checkingNo = { "91 7206594149", "917206594149", "910720659414", "9172065941491" };
            string[] checkingPassword = { "Abdvhvhvsbs", "917206594149A", "vvvccbhcbh8", "hcvxhvzA8" };
            userRegistrationPattern.ValidateFirstName(checkingFirstNames);
            userRegistrationPattern.ValidatelastName(checkingLastNames);
            userRegistrationPattern.ValidateeMail(checkingEMails);
            userRegistrationPattern.ValidateMobileNo(checkingNo);
            userRegistrationPattern.ValidatePassword(checkingPassword);
        }
    }
}
