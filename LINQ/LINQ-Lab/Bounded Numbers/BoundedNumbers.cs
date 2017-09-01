namespace Bounded_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class BoundedNumbers
    {
        public static void Main(string[] args)
        {
            //read the bounds;
            var bounds = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            //read the input numbers;
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            //extract numbers in given bounds;
            numbers = numbers
                .Where(x => x >= bounds.Min() && x <= bounds.Max())
                .ToList();

            //print the result;
            if (numbers.Any())
            {
                Console.WriteLine("{0}", string.Join(" ", numbers));
            }
        }
    }
}
