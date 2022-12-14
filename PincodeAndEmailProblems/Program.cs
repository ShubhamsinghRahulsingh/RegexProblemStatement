using System;
namespace PincodeAndEmailProblems
{
    class Program
    {
        public static string emailFilePath = @"D:\GitRepository\RegexProblemStatement\PincodeAndEmailProblems\EmailList.txt";
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Regex Pattern problems");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("1.Pincode Validation\n2.Email Validation\n3.EmailList Check\n4.Exit");
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
                        email.ValidateEmailSecondPart("abc@bridgelabz");
                        email.ValidateEmailThirdPart("abc@bridgelabz.co");
                        email.ValidateEmailOptionalPart("abc.xyz@bridgelabz.co.in");
                        break;
                    case 3:
                        EmailList emailList = new EmailList();
                        emailList.ReadEmailList(emailFilePath);
                        break;
                    case 4:
                        flag = false;
                        break;
                }
               
            }
        }
    }
}
