using System;
using System.Text;

namespace LeetCodeExamples.Easy
{
    public static class Palindrome
    {
        public static bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }

            var input = x.ToString().ToCharArray();
            Array.Reverse(input);

            if (x.ToString().Equals(new string(input)))
            {
                return true;
            }

            return false;
        }
    }
}
