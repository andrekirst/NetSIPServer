using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;

namespace SIPServer.Management.Database
{
    /// <summary>
    /// 
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// Gets the string.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public static string GetString(this DbDataReader reader, string name)
        {
            return ValidGetValueParameters(reader, name) ? reader.GetString(reader.GetOrdinal(name)) : String.Empty;
        }

        /// <summary>
        /// Gets the int32.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public static int GetInt32(this DbDataReader reader, string name)
        {
            return ValidGetValueParameters(reader, name) ? reader.GetInt32(reader.GetOrdinal(name)) : 0;
        }

        /// <summary>
        /// Valids the get value parameters.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public static bool ValidGetValueParameters(DbDataReader reader, string name)
        {
            return reader != null && !String.IsNullOrEmpty(name) && reader.GetOrdinal(name) >= 0;
        }
    }
}