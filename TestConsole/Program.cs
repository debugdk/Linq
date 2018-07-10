using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "Indicates whether REF*X4*1346645652~ the specified regular expression finds a match in the specified input string." +
                            "Indicates whether REF*X4*1346645645~ the specified regular expression finds";
            string pattern = @"REF\*X4\*[0-9]{10}~";
            Regex rgx = new Regex(pattern);
            string replacement = "";
            string result = rgx.Replace(data, replacement);
            Console.WriteLine("data: " + data);
            Console.WriteLine("result: " + result);
            Console.ReadLine();
        }
    }
}
