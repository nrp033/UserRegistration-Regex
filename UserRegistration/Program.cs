namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n***** Welcome To User Registration *****");

            Console.Write("\n\nEnter First Name :  ");
            string FirstName = Console.ReadLine();
            string RegexRules = "^[A-Z]{1}[a-z]{2,}$";
            Validation.validateString(FirstName, RegexRules);
            Console.ReadLine();

        }
    }
    
}
