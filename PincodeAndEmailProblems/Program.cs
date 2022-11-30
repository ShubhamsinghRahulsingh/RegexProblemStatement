using System;
namespace PincodeAndEmailProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Regex Pattern problems");
            Pincode pin=new Pincode();
            pin.ValidatePinCode("400088");
            pin.restrictAtBeginning("B400088");
            pin.restrictAtEnd("400088B");
            pin.whiteSpaceAllowed("400 088");
        }
    }
}
