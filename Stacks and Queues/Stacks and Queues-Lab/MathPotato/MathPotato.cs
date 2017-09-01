namespace MathPotato
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MathPotato
    {
        public static void Main(string[] args)
        {
            //read the input;
            var input = Console.ReadLine()
                .Split(' ')
                .ToArray();

            //queue for result;
            var resultQueue = new Queue<string>(input);

            //var for step count;
            var step = int.Parse(Console.ReadLine());

            //var for cycle for prime;
            var cycle = 1;

            while (resultQueue.Count > 1)
            {
                for (int i = 1; i < step; i++)
                {
                    var replacedPlayer = resultQueue.Dequeue();
                    resultQueue.Enqueue(replacedPlayer);
                }

                if (IsPrime(cycle))
                {
                    //print the prime player;
                    Console.WriteLine("Prime {0}", resultQueue.Peek());
                }
                else
                {
                    //print the removed player; 
                    Console.WriteLine("Removed {0}", resultQueue.Dequeue());
                }

                cycle++;               
            }

            //print the last player;
            Console.WriteLine("Last is {0}", resultQueue.Dequeue());
        }


        public static bool IsPrime(int candidate)
        {
            // Test whether the parameter is a prime number.
            if ((candidate & 1) == 0)
            {
                if (candidate == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            // Note:
            // ... This version was changed to test the square.
            // ... Original version tested against the square root.
            // ... Also we exclude 1 at the end.
            for (int i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0)
                {
                    return false;
                }
            }
            return candidate != 1;
        }

    }
}
