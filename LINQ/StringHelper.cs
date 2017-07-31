using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LINQ
{
    public static class StringHelper
    {
        public static string changeCase(this string inputString)
        {
            if (inputString.Length > 0)
            {
                char[] arrayString = inputString.ToArray();
                arrayString[0] = char.IsUpper(arrayString[0]) ? char.ToLower(arrayString[0]) : char.ToUpper(arrayString[0]);
                return new string(arrayString);
            }
            return inputString;
        }
    }
}