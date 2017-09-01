namespace Query_Mess
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Text.RegularExpressions;

    public class QueryMess
    {
        public static void Main(string[] args)
        {
            //var for regex;
            var regex = new Regex(@"([^&=?]*)=([^&=]*)");

            //read the current line;
            var line = Console.ReadLine();

            while (line != "END")
            {
                //dictionary for current result;
                var currentResult = new Dictionary<string, List<string>>();
                //var for current matches;
                var matches = regex.Matches(line);

                foreach (Match match in matches)
                {
                    //var for key;
                    var key = Regex.Replace(match.Groups[1].Value, @"((%20|\+)+)", " ").Trim();
                    //var for value;
                    var value = Regex.Replace(match.Groups[2].Value, @"((%20|\+)+)", " ").Trim();

                    //fill the dictionary;
                    if (!currentResult.ContainsKey(key))
                    {
                        currentResult.Add(key, new List<string>());
                        currentResult[key].Add(value);
                    }
                    else
                    {
                        currentResult[key].Add(value);
                    }
                }

                //print the current dictionary;
                foreach (var item in currentResult)
                {
                    Console.Write("{0}=[{1}]", item.Key, string.Join(", ", item.Value));
                }

                Console.WriteLine();
                
                line = Console.ReadLine();
            }
        }
    }
}
