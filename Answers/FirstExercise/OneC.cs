using System;
using System.Collections.Generic;
using System.Linq;

namespace Answers
{
    public class OneC
    {
        /// <summary>
        /// Asks for a list of int. Calculates each number with ^(2 + 8 * 3)
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static List<int> ExC(List<int> list)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                result[i] = Math.Pow(list[i], (2 + 8 * 3));
            }
            return result;
        }

        /// <summary>
        /// Asks for a list of int. Calculates each number with ^(2 + 8 * 3)
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static List<int> ExCLINQ(List<int> list)
        {
            foreach(var num in list)
            {
                num.list = Math.Pow(num, (2 + 8 * 3));
            }
            return list;
        }
    }

}
