using System;
using System.Text.RegularExpressions;

namespace Task4_5
{
    public class WorkWithStringClass
    {
        public bool IsPositiveInt(string str)
        {
            var numberRegex = new Regex(@"(\d*\,|\.*\d+E[+,-]\d+)|(\d*\,|\.*\d+)");
            return numberRegex.IsMatch(str) & numberRegex.Replace(str, String.Empty) == String.Empty;
        }
    }
}