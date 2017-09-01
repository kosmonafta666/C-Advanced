namespace HotPotato
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class HotPotato
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

            while (resultQueue.Count > 1)
            {
                for (int i = 1; i < step; i++)
                {
                    var replacedPlayer = resultQueue.Dequeue();
                    resultQueue.Enqueue(replacedPlayer);
                }

                //print the removed player; 
                Console.WriteLine("Removed {0}", resultQueue.Dequeue());
            }

            //print the last player;
            Console.WriteLine("Last is {0}", resultQueue.Dequeue());
        }
    }
}
