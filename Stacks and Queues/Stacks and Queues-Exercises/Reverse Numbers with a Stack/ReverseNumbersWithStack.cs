namespace Reverse_Numbers_with_a_Stack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class ReverseNumbersWithStack
    {
        static void Main(string[] args)
        {
            //read the input string, split and convert to integer array;
            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            //var for result stack;
            var resultStack = new Stack<int>();

            //fill the result stack;
            foreach (var number in input)
            {
                resultStack.Push(number);
            }

            //print the result stack;
            Console.WriteLine(string.Join(" ", resultStack));
        }
    }
}
