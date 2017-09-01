namespace Sequence_With_Queue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SequenceWithQueue
    {
        public static void Main(string[] args)
        {
            //var for input number;
            var n = long.Parse(Console.ReadLine());

            //var for queue to iterate;
            var myQueue = new Queue<long>();

            //list for result;
            var result = new List<long>();
  
            //add n number to my query;
            myQueue.Enqueue(n);

            //add n to result list;
            result.Add(n);

            while(result.Count < 50)
            {
                //remove the first number in queue;
                var currentNumber = myQueue.Dequeue();

                //asign new three number;
                long firstNumber = currentNumber + 1;
                long secondNumber = (2 * currentNumber) + 1;
                long thirdNumber = currentNumber + 2;

                //add to three number to queue;
                myQueue.Enqueue(firstNumber);
                myQueue.Enqueue(secondNumber);
                myQueue.Enqueue(thirdNumber);

                //add new three number in result list;
                result.Add(firstNumber);
                result.Add(secondNumber);
                result.Add(thirdNumber);
            }//end of while loop;

            //printing the result;
            for (int i = 0; i < 50; i++)
            {
                Console.Write($"{result[i]} ");
            }
        }
    }
}
