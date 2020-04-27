using System;

namespace Answers
{
    public static class OneB
    {
       /// <summary>
       /// Asks for a string. Returns half of the string (floored)
       /// </summary>
       /// <param name="string"></param>
       /// <returns></returns>
       public static string ExI(string @string)
        {
            int half = Math.Floor(@string.Length / 2);
            return @string.Substring(0, half);
        }

        /// <summary>
        /// Asks for a string. Checks if it starts with "a" and ends with "z"
        /// </summary>
        /// <param name="string"></param>
        /// <returns></returns>
        public static void ExII(string @string)
        {
            bool result = false;
            if (@string.StartsWith('a') || @string.EndsWith('z')) 
            {
                result = true;
            }
        }

        /// <summary>
        /// Asks for a string. Removes empty spaces and returns string
        /// </summary>
        /// <param name="string"></param>
        public static string ExIII(string @string)
        {
            @string.Trim();
            return @string;
        }
    }

  
}
