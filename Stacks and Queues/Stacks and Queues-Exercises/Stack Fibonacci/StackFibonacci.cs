namespace Stack_Fibonacci
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StackFibonacci
    {
        public static void Main(string[] args)
        {
            //var for fibonacci number;
            var n = int.Parse(Console.ReadLine());

            //stack for  fibonacci numbers;
            var fibNumbers = new Stack<long>();

            fibNumbers.Push(1);
            fibNumbers.Push(1);

            while (fibNumbers.Count < n)
            {
                //remove the last element from stack;
                var currentNumber = fibNumbers.Pop();
       
                var previousNumber = fibNumbers.Peek();

                //calculate new fibonacci number;
                var newNumber = currentNumber + previousNumber;

                //add last element to stack;
                fibNumbers.Push(currentNumber);
                //add new fibonacci number to stack;
                fibNumbers.Push(newNumber);
            }

            //print the last number in stack;
            Console.WriteLine(fibNumbers.Peek());
        }
    }
}
