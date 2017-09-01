namespace Little_John
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class LittleJohn
    {
        public static void Main(string[] args)
        {
            //regex for arrows;
            var regex = new Regex(@"(>-{5}>)|(>>-{5}>)|(>>>-{5}>>)");

            //list for all arrows;
            var arrows = new List<string>();

            //read the arrows;
            for (int i = 1; i <= 4; i++)
            {
                //read the current line;
                var currentLine = Console.ReadLine();

                //matches for arrows;
                var matches = regex.Matches(currentLine);

                //add matches to arrow list;
                foreach (Match match in matches)
                {
                    arrows.Add(match.Value);
                }

            }//end of reading the arrows;

            //var for small arrows;
            var small = arrows
                .Where(x => x.Count(y => y == '>') == 2)
                .Count();

            //var for medium arrows;
            var medium = arrows
                .Where(x => x.Count(y => y == '>') == 3)
                .Count();

            //var for large arrows;
            var large = arrows
                .Where(x => x.Count(y => y == '>') == 5)
                .Count();

            //var for first dec value;
            var firstDec = int.Parse(String.Format("{0}{1}{2}", small, medium, large));

            //var for first bin value;
            var firstBin = Convert.ToString(firstDec, 2);

            //var for second bin value;
            var secondBin = new string(firstBin.Reverse().ToArray());

            //var for final value;
            var finalValue = Convert.ToInt64(firstBin + secondBin, 2);

            //print final value;
            Console.WriteLine(finalValue);
        }
    }
}
