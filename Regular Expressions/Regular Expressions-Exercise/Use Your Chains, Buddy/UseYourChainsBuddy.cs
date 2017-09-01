namespace Use_Your_Chains__Buddy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class UseYourChainsBuddy
    {
        public static void Main(string[] args)
        {
            //read the input string;
            var inputStr = Console.ReadLine();

            //string for pattern;
            string pattern = @"<p>(.*?)<\/p>";

            //var for regex;
            var regex = new Regex(pattern);

            //collection for matches in input string;
            var matches = regex.Matches(inputStr);

            //string builder for result;
            var result = new StringBuilder();

            foreach (Match match in matches)
            {
                //string to repalce with white spaces;
                var whiteSpaces = @"[^a-z0-9]+";
    
                //var for inner gorup of match;
                var innerStr = match.Groups[1].Value;
                //string with raplaced white spaces;
                var replaced = Regex.Replace(innerStr, whiteSpaces, " ");

                //decript the repalced string;
                foreach (var ch in replaced)
                {
                    if (ch >= 'a' && ch <= 'm')
                    {
                        result.Append((char)(ch + 13));
                    }
                    else if (ch >= 'n' && ch <= 'z')
                    {
                        result.Append((char)(ch - 13));
                    }
                    else
                    {
                        result.Append(ch);
                    }
                }              
            }

            //print the final message;
            Console.WriteLine(result);
        }
    }
}
