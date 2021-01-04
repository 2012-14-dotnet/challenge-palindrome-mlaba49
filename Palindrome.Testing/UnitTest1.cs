using System;
using Palindrome.Domain;
using Xunit;

namespace Palindrome.Testing
{
    public class UnitTest1
    {
        [Fact]
        private void Test1()
        {
            string input1 = "CIVIC";
            string input2 = "MOO";
            PalindromeChecker pc = new PalindromeChecker();

            //Debug.Assert(pc.CheckPalindrome(input1));
            //Debug.Assert(pc.CheckPalindrome(input2));
        }
    }
}
