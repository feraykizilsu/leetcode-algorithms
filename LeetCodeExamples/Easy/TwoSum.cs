using System;
using System.Collections.Generic;

namespace LeetCodeExamples.Easy
{
    public class TwoSum
    {
       public int[] CheckTwoSum(int[] array, int target){

            var dict = new Dictionary<int, int>();

            for (int i = 0; i < array.Length; i++)
            {
                var diff = target - array[i];

                if(dict.ContainsKey(diff))
                {
                    return new int[] { dict[diff], i }; 
                }


                if (!dict.ContainsKey(array[i]))
                {
                    dict.Add(array[i], i);
                }
            }

            throw new SystemException();
        }
    }
}
