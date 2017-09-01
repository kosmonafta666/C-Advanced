namespace Take_Two
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TakeTwo
    {
        public static void Main(string[] args)
        {
            //read the input numbers;
            var inputNumber = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            //list for the result;
            var resultList = inputNumber
                .Where(x => x >= 10 && x <= 20)
                .Distinct()
                .Take(2)
                .ToList();

            //print;
            Console.WriteLine("{0}", string.Join(" ", resultList));
        }
    }
}
