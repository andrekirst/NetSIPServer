using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIPServer.Model
{
    /// <summary>
    /// 
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// Determines whether [is letter or digit] [the specified s].
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns>
        /// 	<c>true</c> if [is letter or digit] [the specified s]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsLetterOrDigit(this string s)
        {
            if(string.IsNullOrEmpty(s))
            {
                return false;
            }
            foreach(char c in s)
            {
                if(!Char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Gets the string.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns></returns>
        public static string GetString(this byte[] array)
        {
            if(array == null || array.Length == 0)
            {
                return String.Empty;
            }
            StringBuilder sb = new StringBuilder();
            foreach(byte b in array)
            {
                sb.Append((char)b);
            }
            return sb.ToString();
        }
    }
}