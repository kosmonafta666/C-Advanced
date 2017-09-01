namespace Match_Count
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Text.RegularExpressions;

    public class MatchCount
    {
        public static void Main(string[] args)
        {
            //read the pattern;
            var pattern = Console.ReadLine();
            //read the input string;
            var inputStr = Console.ReadLine();

            //var for regex;
            var regex = new Regex(pattern);

            //find all matches in input string;
            var matches = regex.Matches(inputStr);

            //print matches count;
            Console.WriteLine(matches.Count);
        }
    }
}
