using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Valid_Usernames
{
    public class ValidUsernames
    {
        public static void Main(string[] args)
        {
            //read the user names;
            var userNames = Console.ReadLine();

            var regex = new Regex(@"\b[^\\\0-9()][A-Za-z0-9_]{2,25}\b");

            var matches = regex.Matches(userNames);

            //array to store couples of user names;
            var couples = new string[2];

            //var for biggest sum lenght of 2 consecutive user names
            var biggestCount = 0;

            for (int i = 0; i < matches.Count - 1; i++)
            {
                //var for current sum lenght of 2 consecutive user names;
                var currentCount = matches[i].Length + matches[i + 1].Length;

                //asign the biggest count;
                if (biggestCount < currentCount)
                {
                    biggestCount = currentCount;
                    couples[0] = matches[i].Value;
                    couples[1] = matches[i + 1].Value;
                }
            }

            //print the result;
            Console.WriteLine(string.Join("\r\n", couples));
        }
    }
}
