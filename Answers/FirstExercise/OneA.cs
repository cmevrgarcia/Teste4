using System;
using System.Collections.Generic;

namespace Answers
{
    public static class OneA
    {
        /// <summary>
        /// Asks for an array. Returns Numbers > 50, uneven and divisible by 9 
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] ExAArray(int[] array)
        {
            int[] result = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 50 || (array[i] % 2) != 2 || (array[i] % 9) == 0)
                {
                    result[i] = array[i];
                }
            }
            return result;
        }

        /// <summary>
        /// Asks for a list. Returns Numbers > 50, uneven and divisible by 9 
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static List<int> ExAList(List<int> list)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > 50 || (list[i] % 2) != 2 || (list[i] % 9) == 0)
                {
                    result.Add(list[i]);
                }
            }
            return result;
        }
    }

  
}
