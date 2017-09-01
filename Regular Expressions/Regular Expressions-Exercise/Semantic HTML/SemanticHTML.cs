namespace Semantic_HTML
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class SemanticHTML
    {
        public static void Main(string[] args)
        {
            //read the input html;
            var line = Console.ReadLine();

            while (line != "END")
            {
                Match openingMatch = Regex.Match(
                    line,
                    @"<(div)([^>]+)(?:class|id)\s*=\s*""(.*?)""(.*?)>");

                Match closingMatch = Regex.Match(
                    line,
                    @"<\/div>\s*<!--\s*(.*?)\s*-->");

                if (openingMatch.Success)
                {
                    line = Regex.Replace(
                        line,
                        @"<(div)([^>]+)(?:class|id)\s*=\s*""(.*?)""(.*?)>",
                        @"$3 $2 $4")
                        .Trim();

                    line = "<" + Regex.Replace(line, @"\s+", " ") + ">";
                }
                else if (closingMatch.Success)
                {
                    line = "</" + closingMatch.Groups[1].Value + ">";
                }

                Console.WriteLine(line);

                line = Console.ReadLine();
            }//end of while loop;


        }
    }
}
