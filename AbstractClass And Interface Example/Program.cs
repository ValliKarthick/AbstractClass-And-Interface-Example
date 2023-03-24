using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AbstractClass_And_Interface_Example
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Redmi.GetBatteryCapacity();

            //MI mi = new MI();
            //Console.WriteLine(mi.MakeCall());
            //Console.WriteLine(mi.SendMessage());
            //Console.WriteLine(mi.GetModelColour());
            //Console.ReadLine();

            //Samsung samsung = new Samsung();
            //Console.WriteLine(samsung.MakeCall());
            //Console.WriteLine(samsung.SendMessage());
            //Console.WriteLine(samsung.GetKeypadType());
            //Console.WriteLine(samsung.GetScreensize());

            //UserDetails userDetails = new UserDetails();

        //getUserName:
        //    Console.WriteLine("Enter Your Name");
        //    string userName = Console.ReadLine();
        //    string userNamePattern = @"^[a-zA-Z]{1,50}$";
        //    if (Regex.IsMatch(userName, userNamePattern))
        //    {

        //    getUserDetails:
        //        Console.WriteLine("Enter Your ContactNumber");
        //        //Console.WriteLine("df");
        //        string contactNumber = Console.ReadLine();
        //        string contactNumberPattern = @"^[0-9]{10}$";
        //        if (Regex.IsMatch(contactNumber, contactNumberPattern))
        //        {
        //            bool validationResult = userDetails.ValidateUserInput(userName, contactNumber);

        //            if (validationResult == true)
        //            {
        //                Console.WriteLine(userName);
        //                Console.WriteLine(contactNumber);
        //            }
        //            else
        //            {
        //                Console.WriteLine("Validation Failed");
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("invalid");
        //            goto getUserDetails;
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("invalid");
        //        goto getUserName;
        //    }

            Dictionary<string, string> mydictionary = new Dictionary<string, string>();

            mydictionary.Add("Key 1", "Value 1");
            mydictionary.Add("Key 2", "Value 2");
            mydictionary.Add("Key 3", "Value 3");

            Console.WriteLine(mydictionary["Key 3"]);


            Console.ReadLine();
        }
    }
}
