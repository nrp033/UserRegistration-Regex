using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Reflection;
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

                case 4:
                 // Mobile Format -E.g. 91 9919819801 - Country code follow by space and 10 digit number
                    Console.Write("\n\nEnter Mobile No :  ");
                    UserInput = Console.ReadLine();
                    RegexRules = "^[1-9]{1,3}[ ][6-9][0-9]{9}$";
                    Validation.validateString(UserInput, RegexRules);
                    goto Home;
                    break;

                case 5:
                    //Rule1 – minimum 8 Characters
                    Console.Write("\n\nEnter Password :  ");
                    UserInput = Console.ReadLine();
                    RegexRules = "^[A-Za-z]{8,}$";
                    Validation.validateString(UserInput, RegexRules);
                    goto Home;
                    break;

                case 6:
                    //Rule2 Minimum 2 UpperCase char 
                    Console.Write("\n\nEnter Password :  ");
                    UserInput = Console.ReadLine();
                    RegexRules = "^(?=.*[A-Z])[A-Za-z]{8,}$";
                    Validation.validateString(UserInput, RegexRules);
                    goto Home;
                    break;

                case 7:
                    //Rule1 – Minimum 1 Number Included  
                    Console.Write("\n\nEnter Password :  ");
                    UserInput = Console.ReadLine();
                    RegexRules = "^(?=.*[A-Z])(?=.*[0-9])[A-Za-z0-9]{8,}$";
                    Validation.validateString(UserInput, RegexRules);
                    goto Home;
                    break;

                case 8:
                    //Rule1 – Exact 1 Special Charector Included  
                    Console.Write("\n\nEnter Password :  ");
                    UserInput = Console.ReadLine();
                    RegexRules = "^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=[^!@#$%_]*[!@#$%_][^!@#$%_]*$)[a-zA-Z0-9!@#$%_]{8,}$";
                    Validation.validateString(UserInput, RegexRules);
                    goto Home;
                    break;


                case 9:
                   // All Given Email Sample Test Are passed
                    Console.Write("\n\nEnter Email :  ");
                    UserInput = Console.ReadLine();
                    RegexRules = "^[a-z]+([.+_-]?[A-Za-z0-9]+)*[@][A-Za-z0-9]+[.][A-Za-z]{2,3}([.][A-Za-z]{2,3})?$";
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
            Console.WriteLine("4) Validate Mobile NO");
            Console.WriteLine("5) Rule 1- 8 char Password");
            Console.WriteLine("6) Rule 2- Minimum 1 UpperCase");
            Console.WriteLine("7) Rule 3- Minimum 1 Number");
            Console.WriteLine("8) Rule 4- Exact 1 Special Charector");
            Console.WriteLine("9) Validating All Given Email Samples");




            Console.WriteLine("\n\n\nPress 0 To Exit !");
        }
    }
    
}
