namespace Truck_Tour
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TruckTour
    {
        public static void Main(string[] args)
        {
            //var number of pumps;
            var pumps = int.Parse(Console.ReadLine());
         
            //queue for pumps;
            var queuePumps = new Queue<int>();
            
            //fill the queue pumps;
            for (int i = 0; i < pumps; i++)
            {
                var currentPump = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                queuePumps.Enqueue(currentPump[0] - currentPump[1]);
            }

            for (int i = 0; i < pumps; i++)
            {
                //check condition of current pump;
                if (IsStop(pumps, queuePumps))
                {
                    Console.WriteLine(i);
                    break;
                }

                //remove first current pump from queue;
                var currentStart = queuePumps.Dequeue();
                //add first current pump to queue;
                queuePumps.Enqueue(currentStart);
            }
        }


        //method to check if current pump is valid
        public static bool IsStop(int pumps, Queue<int> queue)
        {
            //var for fuel;
            var fuel = 0;

            //bool for validation;
            var isStop = true;

            for (int i = 0; i < pumps; i++)
            {
                //remove first current pump;
                var currentPump = queue.Dequeue();

                //increase value for fuel;
                fuel += currentPump;

                //check condition of current pump;
                if (fuel < 0)
                {
                    isStop = false;
                }

                //add first current pump to queue;
                queue.Enqueue(currentPump);               
            }

            return isStop;
        }
    }
}
