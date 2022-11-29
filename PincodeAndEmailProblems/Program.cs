using System;
namespace PincodeAndEmailProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Regex Pattern problems");
            Pincode pin=new Pincode();
            // pin.ValidatePinCode("400088");
            // pin.ValidatePinCode("G00088");
            pin.ValidatePinCode("400088B");
        }
    }
}
