namespace ReverseStrings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main(string[] args)
        {
            //read the input to reverse;
            var inputString = Console.ReadLine();

            //var for stack to reverse string;
            var resultStack = new Stack<char>();

            //fill the stack with char from input string;
            foreach (var ch in inputString)
            {
                resultStack.Push(ch);
            }

            //printing the result;
            while (resultStack.Count > 0)
            {
                Console.Write(resultStack.Pop());
            }

            Console.WriteLine();
        }
    }
}
