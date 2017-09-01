namespace Poisonous_Plants
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class PoisonousPlants
    {
        public static void Main(string[] args)
        {
            //var for number of plants;
            var numberOfPlants = int.Parse(Console.ReadLine());
            //var for plants;
            var plants = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var stackIndex = new Stack<int>();

            stackIndex.Push(0);

            int[] days = new int[numberOfPlants];

            for (int i = 0; i < plants.Length; i++)
            {
                var maxDays = 0;

                while(stackIndex.Count > 0 && plants[stackIndex.Peek()] >= plants[i])
                {
                    maxDays = Math.Max(maxDays, days[stackIndex.Pop()]);
                }

                if (stackIndex.Count > 0)
                {
                    days[i] = maxDays + 1;
                }

                stackIndex.Push(i);
            }

            Console.WriteLine(days.Max());
        }
    }
}
