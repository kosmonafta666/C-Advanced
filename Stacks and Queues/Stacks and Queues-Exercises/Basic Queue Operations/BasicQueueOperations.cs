namespace Basic_Queue_Operations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BasicQueueOperations
    {
        public static void Main(string[] args)
        {
            //read the first input;
            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            //var for second input;
            var numbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            //queue for the result;
            var queueResult = new Queue<int>();

            //var for length of the queue;
            var queueLenght = input[0];
            //var for dequeue from the queue;
            var dequeueCount = input[1];
            //var for match element;
            var matchElelment = input[2];

            //fill the queue;
            for (int i = 0; i < queueLenght; i++)
            {
                queueResult.Enqueue(numbers[i]);
            }

            //dequeue the elements;
            for (int i = 1; i <= dequeueCount; i++)
            {
                queueResult.Dequeue();
            }

            if (queueResult.Contains(matchElelment))
            {
                Console.WriteLine("true");
            }
            else if (queueResult.Count > 0)
            {
                Console.WriteLine(queueResult.Min());
            }
            else
            {
                Console.WriteLine(0);
            }

        }
    }
}
