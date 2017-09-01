namespace Srabsko_Unleashed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Text.RegularExpressions;

    public class SrabskoUnleashed
    {
        public static void Main(string[] args)
        {
            //dictionary for result;
            var result = new Dictionary<string, Dictionary<string, long>>();

            //regex to split the input;
            string pattern = @"(.*?) @(.*?) (\d+) (\d+)";

            //read the input;
            var input = Console.ReadLine();

            while (input != "End")
            {
                if (Regex.IsMatch(input, pattern))
                {
                    //var for match in input string to extract groups;
                    var match = Regex.Match(input, pattern);

                    //var for singer;
                    var singer = match.Groups[1].Value;
                    //var for venue;
                    var venue = match.Groups[2].Value;
                    //var for ticket price;
                    var ticketPrice = int.Parse(match.Groups[3].Value);
                    //var for ticket count;
                    var ticketCount = int.Parse(match.Groups[4].Value);
                    //var for total money;
                    var totalMoney = ticketPrice * ticketCount;

                    //fill the dictionary;
                    if (!result.ContainsKey(venue))
                    {
                        result.Add(venue, new Dictionary<string, long>());

                        result[venue].Add(singer, totalMoney);
                    }
                    else
                    {
                        if (!result[venue].ContainsKey(singer))
                        {
                            result[venue].Add(singer, totalMoney);
                        }
                        else
                        {
                            result[venue][singer] += totalMoney;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            //printing the result;
            foreach (var venue in result)
            {
                Console.WriteLine(venue.Key);

                foreach (var singer in venue.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }
    }
}
