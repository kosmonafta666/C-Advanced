namespace Reverse_And_Exclude
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ReverseAndExclude
    {
        public static void Main(string[] args)
        {
            //read the numbers;
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .Reverse()
                .ToList();

            //read the divider;
            var divider = int.Parse(Console.ReadLine());

            Predicate<int> isDivide = x => x % divider == 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (isDivide(numbers[i]))
                {
                    numbers.Remove(numbers[i]);
                    i--;
                }
            }

            Console.WriteLine("{0}", string.Join(" ", numbers));
        }
    }
}
