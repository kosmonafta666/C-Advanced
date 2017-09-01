namespace Find_Evens_or_Odds
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FindEvensOrOdds
    {
        public static void Main(string[] args)
        {
            //read the range of numbers;
            var rangeNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            //read the even or odd command;
            var typeNumbers = Console.ReadLine();


            //var for min range;
            var minRange = rangeNumbers[0];
            //var for max range;
            var maxRange = rangeNumbers[1];

            //create enumarable sequence from min range to max range;
            var numbers = Enumerable.Range(minRange, maxRange - minRange + 1);

            //predicate to check number is even or odd;
            Predicate<int> isEven = x => x % 2 == 0;

            PrintCheckedNumbers(numbers, typeNumbers, isEven);
        }

        //method to print number by given criteria;
        private static void PrintCheckedNumbers(IEnumerable<int> numbers, string typeNumbers, Predicate<int> isEven)
        {
            foreach (var number in numbers)
            {
                if (typeNumbers == "even")
                {
                    if (isEven(number))
                    {
                        Console.Write("{0} ", number);
                    }
                }
                else
                {
                    if (!isEven(number))
                    {
                        Console.Write("{0} ", number);
                    }
                }
            }
        }
    }
}
