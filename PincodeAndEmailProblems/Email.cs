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
        public void ValidateEmailFirstPart(string input)
        {
            if (Regex.IsMatch(input, emailFirstPart))
                Console.WriteLine("{0} as Email Id is valid", input);
            else
                Console.WriteLine("{0} as Email Id is invalid ", input);

        }
    }
}
