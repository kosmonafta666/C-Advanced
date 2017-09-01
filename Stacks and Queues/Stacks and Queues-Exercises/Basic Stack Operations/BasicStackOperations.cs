namespace Basic_Stack_Operations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BasicStackOperations
    {
        public static void Main(string[] args)
        {
            //read the first input, split and convert to integer array;
            var operations = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            //read the numbers of stack;
            var numbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).
                ToArray();

            //stack for result;
            var stackResult = new Stack<int>();

            //var for length of stack;
            var stackLength = operations[0];
            //var for numbers of pop opeartions;
            var popCount = operations[1];
            //var for match number in stack;
            var matchNumber = operations[2];

            //fill the result stack;
            for (int i = 0; i < stackLength; i++)
            {
                stackResult.Push(numbers[i]);
            }

            //execute the pop operations;
            for (int i = 1; i <= popCount; i++)
            {
                stackResult.Pop();
            }

            if (stackResult.Contains(matchNumber))
            {
                Console.WriteLine("true");
            }
            else if (stackResult.Count() > 0)
            {
                Console.WriteLine(stackResult.Min());
            }
            else if (stackResult.Count() == 0)
            {
                Console.WriteLine(0);
            }
        }
    }
}
