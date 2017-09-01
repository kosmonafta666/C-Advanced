namespace Extract_Quotations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Text.RegularExpressions;

    public class ExtractQuotations
    {
        public static void Main(string[] args)
        {
            //read the input string;
            var inputStr = Console.ReadLine();

            //string for pattern;
            var pattern = "('|\")(.+?)\\1";

            //var for regex;
            var regex = new Regex(pattern);

            //var for matches in inputStr;
            var matches = regex.Matches(inputStr);

            //print the matches;
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[2].Value);
            }

        }
    }
}
