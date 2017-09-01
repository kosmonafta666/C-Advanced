namespace List_Of_Predicates
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ListOfPredicates
    {
        public static void Main(string[] args)
        {
            //read the range of numbers;
            var range = int.Parse(Console.ReadLine());

            //read the dividers;
            var dividers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            Func<int, int, bool> filter = (n, d) => n % d == 0;

            SelectAndPrint(range, dividers, filter);
        }

        //method to print all numbers in given range divided by given dividers;
        private static void SelectAndPrint(int range, int[] dividers, Func<int, int, bool> filter)
        {
            bool flag = true;

            for (int i = 1; i <= range; i++)
            {
                flag = true;

                foreach (var divider in dividers)
                {
                    if (!filter(i, divider))
                    {
                        flag = false;
                    }
                }

                if (flag)
                {
                    Console.Write("{0} ", i);
                }               
            }
        }
    }
}
