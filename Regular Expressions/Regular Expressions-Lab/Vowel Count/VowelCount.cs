namespace Vowel_Count
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Text.RegularExpressions;

    public class VowelCount
    {
        public static void Main(string[] args)
        {
            //read the input string;
            var inputStr = Console.ReadLine();

            //string for pattern for vowels;
            string pattern = @"[AEIOUYaeiouy]";

            //var for regex;
            var regex = new Regex(pattern);

            //find all matches in input string;
            var matches = regex.Matches(inputStr);

            //print the count of matches;
            Console.WriteLine("Vowels: {0}", matches.Count);
        }
    }
}
