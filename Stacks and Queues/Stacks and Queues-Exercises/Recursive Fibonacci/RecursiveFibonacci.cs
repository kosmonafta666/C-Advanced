namespace Recursive_Fibonacci
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RecursiveFibonacci
    {
        //array for already calculated numbers;
        static long[] cashe;

        public static void Main(string[] args)
        {
            //read the input number;
            var n = long.Parse(Console.ReadLine());

            //initializing the cashe array;
            cashe = new long[n + 3];

            cashe[0] = 0;
            cashe[1] = 1;
            cashe[2] = 1;

            //var for result;
            var result = Fibonacci(n);

            Console.WriteLine(result);
        }

        //method to calculate fibonacci with recursive and memoization;
        public static long Fibonacci (long number)
        {
            //if number is not calculated;
            if (cashe[number] == 0)
            {
                cashe[number] = Fibonacci(number - 1) + Fibonacci(number - 2);
            }

            return cashe[number];
        }
    }
}
