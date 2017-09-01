namespace Custom_Comparator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CustomComparator
    {
        public static void Main(string[] args)
        {
            //read the input, split and convert to int array;
            var inputNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();


            //sort input numbers with comparator;
            Array.Sort(inputNumbers, (x, y) =>
            {
                if (x % 2 == 0 && y % 2 != 0)
                {
                    return -1;
                }

                if (x % 2 != 0 && y % 2 == 0)
                {
                    return 1;
                }

                if (x > y)
                {
                    return 1;
                }

                if (x < y)
                {
                    return -1;
                }

                return 0;
            });

            //print sorted numbers;
            Console.WriteLine("{0}", string.Join(" ", inputNumbers));
        }
    }
}
