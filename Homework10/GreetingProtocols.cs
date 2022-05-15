using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    internal class GreetingProtocols
    {
        public static void WelcomeGreeting()
        {
            Console.WriteLine("Hello and welcome!");
            Console.WriteLine("This is a basically useless app designed");
            Console.WriteLine("for the one purpose of practicing the creation");
            Console.WriteLine("and calling of Methods.");
            Console.WriteLine("\n");
        }

        public static string GetFirstName()
        {
            string? firstName;
            do
            {
                Console.Write("Enter your first name please: ");
                firstName = Console.ReadLine();
            }   while (string.IsNullOrEmpty(firstName));
            return firstName;
        }

        public static void SayHello(string firstName)
        {
            Console.WriteLine($"Hello {firstName}, thank you for trying out my app.");
            Console.WriteLine("\n");
        }
        
    }
}
