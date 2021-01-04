using System;

namespace Palindrome.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean exit = false;
            string input;
            Console.WriteLine("Welcome to the palindrome program.");
            while(exit == false) {
                Console.WriteLine("Please input a word or sentence.");

                Console.WriteLine("Would you like to exit? Type 'yes' to do so.");
                input = Console.ReadLine().ToUpper();
                if(input == "YES") exit = true;
            }
        }
    }
}
