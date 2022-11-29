using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PincodeAndEmailProblems
{
    public class Pincode
    {
        const string PIN_CODE_PATTERN = "^[0-9]{6}$";
        public void ValidatePinCode(string input)
        {
            if (Regex.IsMatch(input, PIN_CODE_PATTERN))
                Console.WriteLine("Pincode is valid");
            else
                Console.WriteLine("Pincode is invalid ");

        }
    }
}
