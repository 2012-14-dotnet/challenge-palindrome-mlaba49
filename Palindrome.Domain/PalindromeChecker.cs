using System;

namespace Palindrome.Domain {

    public class PalindromeChecker {
        public bool CheckPalindrome(string input) {
            char[] forwards = input.ToCharArray();
            char[] backwards = new char[forwards.Length];
            for(int i = 0; i < forwards.Length; i++) {
                backwards[forwards.Length - i - 1] = forwards[i];
            }

            Console.WriteLine(forwards);
            Console.WriteLine(backwards);

            return true;
        }
    }

}