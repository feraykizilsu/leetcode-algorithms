using System;
namespace LeetCodeExamples.Easy
{
    public static class ReverseInteger
    {
        public static int  Reverse(int x)
        {
            bool isNegative = false;
            int result = 0;

            if (x < 0)
            {
                isNegative = true;
                x = -x;
            }

            var charArray = x.ToString().ToCharArray();
            Array.Reverse(charArray);
             
            if(!Int32.TryParse( new string(charArray), out result ))
            {

                return 0;
            }

            return isNegative ? -result : result;
        }
    }
}
