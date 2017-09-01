namespace Sets_Of_Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SetsOfElements
    {
        public static void Main(string[] args)
        {
            //read the n and m numbers;
            var setLengths = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            //var for length of n set;
            var n = setLengths[0];
            //var for length of m set;
            var m = setLengths[1];

            //hash set for first length;
            var firstSet = new HashSet<int>();
            //hash set for second length;
            var secondSet = new HashSet<int>();
            //list for result;
            var result = new List<int>();

            //fill the first set;
            for (int i = 1; i <= n; i++)
            {
                //read the current element of first length;
                var currentNumber = int.Parse(Console.ReadLine());
                //add to first hash set;
                firstSet.Add(currentNumber);
            }

            //fill the second set;
            for (int i = 1; i <= m; i++)
            {
                //read the current element of first length;
                var currentNumber = int.Parse(Console.ReadLine());
                //add to first hash set;
                secondSet.Add(currentNumber);
            }

            //fill the result list;
            foreach (var firstNumber in firstSet)
            {
                if (secondSet.Contains(firstNumber))
                {
                    result.Add(firstNumber);
                }
            }

            //print the result;
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
