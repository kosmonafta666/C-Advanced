using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Extract_Integer_Numbers
{
    public class ExtractIntegerNumbers
    {
        public static void Main(string[] args)
        {
            //read the input string;
            var inputStr = Console.ReadLine();

            //string for pattern;
            var pattern = @"\d+";

            //var for regex;
            var regex = new Regex(pattern);

            //var for matches in input string;
            var matches = regex.Matches(inputStr);

            //printing the matches;
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }

        }
    }
}
