namespace Sum_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SumNumbers
    {
        public static void Main(string[] args)
        {
            //func for parsing from string to int;
            Func<string, int> parseToInt = n => int.Parse(n);

            //read the input string, split and convert to int;
            var inputStr = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(parseToInt)
                .ToList();

            Console.WriteLine("{0}", inputStr.Count);

            Console.WriteLine("{0}", inputStr.Sum());
        }
    }
}
