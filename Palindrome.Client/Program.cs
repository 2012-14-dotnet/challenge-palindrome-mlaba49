using System;
using Palindrome.Domain;

namespace Palindrome.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean exit = false;
            string input;
            PalindromeChecker myChecker = new PalindromeChecker();
            Console.WriteLine("Welcome to the palindrome program.");
            while(exit == false) {
                Console.WriteLine("Please input a word or sentence.");
                input = Console.ReadLine().ToUpper();

                if(input != "") {
                    if(myChecker.CheckPalindrome(input) == true) Console.WriteLine(input + " is a palindrome.");
                    else Console.WriteLine(input + " is not a palindrome.");
                }
                else Console.WriteLine("You need to put something in, dingbat!");

                Console.WriteLine("Would you like to exit? Type 'yes' to do so.");
                input = Console.ReadLine().ToUpper();
                if(input == "YES") exit = true;
            }
        }
    }
}
