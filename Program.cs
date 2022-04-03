using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace User_Registration_Regex
{
    public class Program
    {
        static void Main(string[] args)
        {
            UserRegistrationPattern userRegistrationPattern = new UserRegistrationPattern();
            string[] checkingFirstNames = { "Prem", "Pop", "Ho", "prem" };
            string[] checkingLastNames = { "kumar", "khan", "So", "kumaran" };
            string[] checkingEMails = { "abc@bl.co", "abc.xyz@bl.co", "abc.xyz@bl.co.in", "abc.@bl.co" };
            string[] checkingNo = { "91 7206594149", "917206594149", "910720659414", "9172065941491" };
            string[] checkingPassword = { "bdvhvhv8sBbs", "91720659414@9A", "vvvccbhcbh8", "hcvxhvzA8" };
            string[] checkingEmails2 = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc-100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com" };
            userRegistrationPattern.ValidateFirstName(checkingFirstNames);
            userRegistrationPattern.ValidatelastName(checkingLastNames);
            userRegistrationPattern.ValidateeMail(checkingEMails);
            userRegistrationPattern.ValidateMobileNo(checkingNo);
            userRegistrationPattern.ValidatePassword(checkingPassword);
            userRegistrationPattern.ValidateeMail(checkingEmails2);
        }
    }
}
