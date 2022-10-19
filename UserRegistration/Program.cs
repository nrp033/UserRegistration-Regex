using System.Collections.Generic;
using System.Xml.Linq;

namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n***** Welcome To User Registration *****");

        Home:
            Menu();
            Console.Write("Enter Your Choice : ");
            int option = Convert.ToInt32(Console.ReadLine());
            string UserInput;
            string RegexRules;
            switch (option)
            {
                case 0:
                    break;

                case 1:
                  //First name starts with Cap and has minimum 3 characters
                    Console.Write("\n\nEnter First Name :  ");
                    UserInput = Console.ReadLine();
                    RegexRules = "^[A-Z]{1}[a-z]{2,}$";
                    Validation.validateString(UserInput, RegexRules);
                    goto Home;
                    break;

                case 2:
                  //Name - Last name starts with Cap and has minimum 3 characters
                    Console.Write("\n\nEnter Last Name :  ");
                    UserInput = Console.ReadLine();
                    RegexRules = "^[A-Z]{1}[a-z]{2,}$";
                    Validation.validateString(UserInput, RegexRules);
                    goto Home;
                    break;
                    //abc.xyz @bl.co.in

                case 3:
                   // E.g.abc.xyz @bl.co.in
                    Console.Write("\n\nEnter Email :  ");
                    UserInput = Console.ReadLine();
                    RegexRules = "^[a-z]+([._][A-Za-z0-9]+)*[@][A-Za-z]+[.][A-Za-z]{2,3}([.][A-Za-z]{2})?$";
                    Validation.validateString(UserInput, RegexRules);
                    goto Home;
                    break;




                default:
                    Console.WriteLine("\nWrong Input !");
                    goto Home;
                    break;

            }
           

        }
        static void Menu()
        {
            Console.WriteLine("\n\n1) Validate First Name ");
            Console.WriteLine("2) Validate Last Name ");
            Console.WriteLine("3) Validate Email ID");


            Console.WriteLine("\n\n\nPress 0 To Exit !");
        }
    }
    
}
