using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIPServer
{
    /// <summary>
    /// 
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// Determines whether [is valid port] [the specified value].
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// 	<c>true</c> if [is valid port] [the specified value]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsValidPort(this int value)
        {
            return value >= 0 && value < 65536;
        }
    }
}
