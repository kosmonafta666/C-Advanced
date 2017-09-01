namespace Second_Nature
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SecondNature
    {
        public static void Main(string[] args)
        {
            //read the flowers string;
            var inputFlowers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            //read the buckets string;
            var inputBuckets = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            //queue for flowers;
            var flowers = new Queue<int>(inputFlowers);

            //stack for buckets;
            var buckets = new Stack<int>(inputBuckets);

            //var for remaining water;
            var secondNature = new List<int>();

            var currentWater = buckets.Peek();

            while (flowers.Count > 0 && buckets.Count > 0)
            {
                //remove first flower;
                int currFlower = flowers.Dequeue();
                //remove last bucket;
                int currBucket = buckets.Pop();

                //check the condition;
                if (currFlower == currBucket)
                {
                    secondNature.Add(currFlower);
                }
                else if (currFlower > currBucket)
                {
                    currFlower -= currBucket;

                    //reasign the flowers;
                    var queueToArray = flowers.ToArray();

                    flowers.Clear();

                    flowers.Enqueue(currFlower);

                    foreach (var item in queueToArray)
                    {
                        flowers.Enqueue(item);
                    }
                }
                else if (currFlower < currBucket)
                {
                    //var for remaining water;
                    int remainingWater = currBucket - currFlower;
                    //var for water to add to buckets;
                    int waterToAdd = 0;

                    if (buckets.Count == 0)
                    {
                        waterToAdd = remainingWater;
                    }
                    else
                    {
                        waterToAdd = buckets.Pop() + remainingWater;
                    }

                    buckets.Push(waterToAdd);
                }
            }

            //printing the buckets or flowers;
            if (buckets.Count > 0)
            {
                Console.WriteLine(string.Join(" ", buckets));
            }
            else if (flowers.Count > 0)
            {
                Console.WriteLine(string.Join(" ", flowers));
            }

            //printing the second nature;
            if (secondNature.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                Console.WriteLine(string.Join(" ", secondNature));
            }

        }
    }
}