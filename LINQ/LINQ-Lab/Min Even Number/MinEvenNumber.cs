namespace Min_Even_Number
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MinEvenNumber
    {
        public static void Main(string[] args)
        {
            //read the input numbers;
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            //var for min even value;
            var result = numbers
                .Where(x => x % 2 == 0)
                .DefaultIfEmpty(double.MinValue)
                .Min();

            //print the result;
            if (result != double.MinValue)
            {
                Console.WriteLine("{0:F2}", result);
            }
            else
            {
                Console.WriteLine("No match");
            }
        }
    }
}
