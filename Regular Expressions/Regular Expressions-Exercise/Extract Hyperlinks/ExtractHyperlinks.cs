namespace Extract_Hyperlinks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class ExtractHyperlinks
    {
        public static void Main(string[] args)
        {
            var regex = new Regex(@"<a\s+[^>]*?href\s*=(.*?)>.*?<\s*\/\s*a\s*>");

            //read the input string;
            var inputHtml = Console.ReadLine();

            //string builder for all html lines;
            var allLines = new StringBuilder();

            while (inputHtml != "END")
            {
                allLines.Append(inputHtml).Append(" ");

                inputHtml = Console.ReadLine();
            }

            var matches = regex.Matches(allLines.ToString());

            //extract the href from group 1 and print it;
            foreach (Match match in matches)
            {
                string currentHref = match.Groups[1].Value.Trim();

                if (currentHref[0] == '"')
                {
                    Console.WriteLine(
                        currentHref
                        .Split(new[] { '"' }, StringSplitOptions.RemoveEmptyEntries)
                        .First());                   
                }
                else if (currentHref[0] == '\'')
                {
                    Console.WriteLine(
                        currentHref
                        .Split(new[] { '\'' }, StringSplitOptions.RemoveEmptyEntries)
                        .First());
                }
                else
                {
                    Console.WriteLine(
                        currentHref
                        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .First());
                }
            }
        }
    }
}
