namespace Sort_Even_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SortEvenNumbers
    {
        public static void Main(string[] args)
        {
            //read the input string, split and convert to int;
            var inputStr = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            //list for the result;
            var result = inputStr
                .Where(x => x % 2 == 0)
                .OrderBy(x => x)
                .ToList();

            Console.WriteLine("{0}", string.Join(", ", result));

        }
    }
}
