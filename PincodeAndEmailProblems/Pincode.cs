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
        const string restrictCharAtBeginning = "^[0-9]{7}$";
        const string restrictCharAtEnd = "^[0-9]{7}$";
        const string SpaceAllowed = "^[0-9]{3}[ ]{0,1}[0-9]{3}$";
        public void ValidatePinCode(string input)
        {
            if (Regex.IsMatch(input, PIN_CODE_PATTERN))
                Console.WriteLine("{0} as Pincode is valid",input);
            else
                Console.WriteLine("{0} as Pincode is invalid ",input);

        }
        public void restrictAtBeginning(string input)
        {
            if (Regex.IsMatch(input, restrictCharAtBeginning))
                Console.WriteLine("{0} as Pincode is valid", input);
            else
                Console.WriteLine("{0} as Pincode is invalid ", input);

        }
        public void restrictAtEnd(string input)
        {
            if (Regex.IsMatch(input, restrictCharAtEnd))
                Console.WriteLine("{0} as Pincode is valid", input);
            else
                Console.WriteLine("{0} as Pincode is invalid ", input);

        }
        public void whiteSpaceAllowed(string input)
        {
            if (Regex.IsMatch(input, SpaceAllowed))
                Console.WriteLine("{0} as Pincode is valid", input);
            else
                Console.WriteLine("{0} as Pincode is invalid ", input);

        }
    }
}
