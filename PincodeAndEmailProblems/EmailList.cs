using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PincodeAndEmailProblems
{
    public class EmailList
    {
        string[] list;
        const string emailsCheck = "^[a-zA-Z]+[.+_-]{0,1}[a-z0-9]+[@][a-zA-Z0-9]+[.][a-z]{2,3}([.][a-z]{2,3}){0,1}$";
        public void ReadEmailList(string filepath)
        {
            var email=File.ReadAllText(filepath);
            list = email.Split(",");
            Validate(list);
        }
        public void Validate(string[] input)
        {
            foreach (var email in input)
            {
                if (Regex.IsMatch(email, emailsCheck))
                    Console.WriteLine("{0} as Email Id is valid", email);
                else
                    Console.WriteLine("{0} as Email Id is invalid ", email);
            }
        }
    }
}
