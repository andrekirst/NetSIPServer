using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.SqlServer.Server;

namespace SIPServer.Database.ClrFunctions
{
    public static class SqlFunctions
    {
        [SqlFunction(
            Name = "IsMatchingRegex",
            SystemDataAccess = SystemDataAccessKind.Read
        )]
        public static bool IsMatchingRegex(string input, string pattern)
        {
            return String.IsNullOrEmpty(input) || String.IsNullOrEmpty(pattern) ? false : Regex.IsMatch(input, pattern);
        }

        [SqlFunction(
            Name = "Contains",
            SystemDataAccess = SystemDataAccessKind.None
        )]
        public static bool Contains(string str, string value)
        {
            return String.IsNullOrEmpty(str) || String.IsNullOrEmpty(value) ? false : str.Contains(value);
        }

        [SqlFunction(
            Name = "EndsWith",
            SystemDataAccess = SystemDataAccessKind.None
        )]
        public static bool EndsWith(string str, string value)
        {
            return String.IsNullOrEmpty(str) || String.IsNullOrEmpty(value) ? false : str.EndsWith(value);
        }
    }
}