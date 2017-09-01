using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Non_Digit_Count
{
    public class NonDigitCount
    {
        public static void Main(string[] args)
        {
            //read the input string;
            var inputStr = Console.ReadLine();

            //string for pattern;
            string pattern = @"[^0123456789]";

            //var for reegex;
            var regex = new Regex(pattern);

            //var matches in input string;
            var matches = regex.Matches(inputStr);

            //print the matches count;
            Console.WriteLine("Non-digits: {0}", matches.Count);
        }
    }
}
