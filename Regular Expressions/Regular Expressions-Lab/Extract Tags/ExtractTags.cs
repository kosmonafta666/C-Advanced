namespace Extract_Tags
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class ExtractTags
    {
        public static void Main(string[] args)
        {
            //read the input;
            var input = Console.ReadLine();

            //string for pattern;
            var pattern = @"<.+?>";

            //var for regex;
            var regex = new Regex(pattern);

            while (input != "END")
            {
                //var for current matches;
                var currentMatches = regex.Matches(input);

                foreach (var match in currentMatches)
                {
                    Console.WriteLine(match.ToString().Trim());
                }

                input = Console.ReadLine();
            }
        }
    }
}
