using System;
namespace PincodeAndEmailProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Regex Pattern problems");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.Pincode Validation\n2.Email Validation\n3.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Pincode pin = new Pincode();
                        pin.ValidatePinCode("400088");
                        pin.restrictAtBeginning("B400088");
                        pin.restrictAtEnd("400088B");
                        pin.whiteSpaceAllowed("400 088");
                        break;
                    case 2:
                        Email email = new Email();
                        email.ValidateEmailFirstPart("abc");
                        break;
                    case 3:
                        flag = false;
                        break;
                }
               
            }
        }
    }
}
