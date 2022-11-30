using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PincodeAndEmailProblems
{
    public class Email
    {
        const string emailFirstPart = "^[a-z]";
        const string emailSecondPart = "^[a-zA-Z]+[@][a-zA-Z]{2,}$";
        const string emailThirdPart = "^[a-zA-Z]+[@][a-zA-Z]+[.][a-z]{2,}$";
        const string emailOptionalPart = "^[a-zA-Z]+[.+_-]{0,1}[a-z]+[@][a-zA-Z]+[.][a-z]{2,3}([.][a-z]{2}){0,1}$";
        public void ValidateEmailFirstPart(string input)
        {
            if (Regex.IsMatch(input, emailFirstPart))
                Console.WriteLine("{0} as Email Id is valid", input);
            else
                Console.WriteLine("{0} as Email Id is invalid ", input);

        }
        public void ValidateEmailSecondPart(string input)
        {
            if (Regex.IsMatch(input, emailSecondPart))
                Console.WriteLine("{0} as Email Id is valid", input);
            else
                Console.WriteLine("{0} as Email Id is invalid ", input);

        }
        public void ValidateEmailThirdPart(string input)
        {
            if (Regex.IsMatch(input, emailThirdPart))
                Console.WriteLine("{0} as Email Id is valid", input);
            else
                Console.WriteLine("{0} as Email Id is invalid ", input);

        }
        public void ValidateEmailOptionalPart(string input)
        {
            if (Regex.IsMatch(input, emailOptionalPart))
                Console.WriteLine("{0} as Email Id is valid", input);
            else
                Console.WriteLine("{0} as Email Id is invalid ", input);

        }
    }
}
