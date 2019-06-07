using System;
using LeetCodeExamples.Easy;

namespace LeetCodeExamples
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //var result = ReverseInteger.Reverse(123);
            //var result = Palindrome.IsPalindrome(123);
            var result = LongestCommonPrefix.FindLongestCommonPrefix(new string[] { "dog", "racecar", "car" });
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
