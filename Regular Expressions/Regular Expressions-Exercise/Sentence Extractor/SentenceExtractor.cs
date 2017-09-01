namespace Sentence_Extractor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Text.RegularExpressions;

    public class SentenceExtractor
    {
        public static void Main(string[] args)
        {
            //read the match word;
            var matchWord = Console.ReadLine();

            //read the input string;
            var inputStr = Console.ReadLine();

            var pattern = String.Format(@"[^.!?;]*\b({0})\b[^.?!;]*[.?!;]", matchWord);

            var regex = new Regex(pattern);

            var matches = regex.Matches(inputStr);

            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
