namespace Find_and_Sum_Integers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FindAndSumIntegers
    {
        public static void Main(string[] args)
        {
            //read the the input, convert to string array;
            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            //list for all numbers in input;
            var numbers = new List<long>();

            //fill the numbers list;
            foreach (var str in input)
            {
                //var for find current number;
                int currentNumber = 0;

                if (int.TryParse(str, out currentNumber))
                {
                    numbers.Add(currentNumber);
                }
            }

            //print the result;
            if (!numbers.Any())
            {
                Console.WriteLine("No match");
            }
            else
            {
                Console.WriteLine(numbers.Sum());
            }
        }
    }
}
