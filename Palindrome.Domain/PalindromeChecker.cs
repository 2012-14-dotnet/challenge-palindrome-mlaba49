using System;

namespace Palindrome.Domain {

    public class PalindromeChecker {
        public bool CheckPalindrome(string input) {
            char[] forwards = input.ToCharArray();
            char[] backwards = new char[forwards.Length];
            for(int i = 0; i < forwards.Length; i++) {
                backwards[forwards.Length - i - 1] = forwards[i];
            }

            for(int i = 0; i < forwards.Length; i++) {
                if(forwards[i] != backwards[i]) return false;
            }
            return true;
        }
    }

}