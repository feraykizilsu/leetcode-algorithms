using System;
using System.Text;

namespace LeetCodeExamples.Easy
{
    public static class LongestCommonPrefix
    {
        public static string FindLongestCommonPrefix(string[] strs)
        {
            if(strs == null || strs.Length == 0)
            {
                return string.Empty; 
            }

            var firstElement = strs[0].ToCharArray();
            var result = new StringBuilder();

            for (int i = 0; i < firstElement.Length; i++)
            {
                var item = firstElement[i];
                var itemAppendStatus = true;

                for (int j = 1; j < strs.Length; j++)
                {
                    if (strs[j].Length <= i || strs[j][i] != item)
                    {
                        itemAppendStatus = false;
                        break;
                    }

                }

                if(itemAppendStatus)
                {
                    result.Append(item);
                }
                else
                {
                    break; 
                }
            }

            return result.ToString();

        }
    }
}
