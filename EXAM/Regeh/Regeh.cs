namespace Regeh
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Text.RegularExpressions;

    public class Regeh
    {
        public static void Main(string[] args)
        {
            //read the input string;
            var inputStr = Console.ReadLine();

            //string for pattern;
            var pattern = @"\[\w+<(\d+)REGEH(\d+)>\w+\]";


            //var for regex;
            var regex = new Regex(pattern);

            //var for matches;
            var matches = regex.Matches(inputStr);

            //list for number in the matches;
            var numbers = new List<int>();

            //string builder for the result;
            var result = new StringBuilder();

            if (matches.Count > 0)
            {
                //fill the numbers list;
                foreach (Match match in matches)
                {
                    numbers.Add(int.Parse(match.Groups[1].Value));

                    numbers.Add(int.Parse(match.Groups[2].Value));
                }

                //var for current sum of numbers;
                var currentSum = 0;

                //fill the result;
                foreach (var number in numbers)
                {
                    currentSum += number;
                    
                    result.Append(inputStr[currentSum % (inputStr.Length - 1)]);
                }
            }

            //printing the result;
            Console.WriteLine(result);         
        }
    }
}
