using System;
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
            => string.IsNullOrEmpty(input) || string.IsNullOrEmpty(pattern) ? false : Regex.IsMatch(input, pattern);

        [SqlFunction(
            Name = "Contains",
            SystemDataAccess = SystemDataAccessKind.None
        )]
        public static bool Contains(string str, string value)
            => string.IsNullOrEmpty(str) || string.IsNullOrEmpty(value) ? false : str.Contains(value);

        [SqlFunction(
            Name = "EndsWith",
            SystemDataAccess = SystemDataAccessKind.None
        )]
        public static bool EndsWith(string str, string value)
            => string.IsNullOrEmpty(str) || string.IsNullOrEmpty(value) ? false : str.EndsWith(value);
    }
}