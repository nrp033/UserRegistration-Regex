using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class Validation
    {
        public static void  validateString(string sample,string RegexRule)
        {
            if( Regex.IsMatch(sample, RegexRule))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n  "+sample+ " is Valid Input !");
                Console.ResetColor();

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("\n\n  " + sample +" is Invalid Input !");
                Console.ResetColor();

            }
        }
    }
}
