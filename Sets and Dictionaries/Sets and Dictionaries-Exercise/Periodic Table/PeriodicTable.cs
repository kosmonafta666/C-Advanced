namespace Periodic_Table
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PeriodicTable
    {
        public static void Main(string[] args)
        {
            //read the number of compounds;
            var n = int.Parse(Console.ReadLine());

            //hash set for result;
            var resultSet = new SortedSet<string>();

            //fill the result hash set;
            for (int i = 1; i <= n; i++)
            {
                //read the current compound, and splitted to elements;
                var currentCompound = Console.ReadLine()
                    .Split(' ');

                //fill the result hash set;
                foreach (var element in currentCompound)
                {
                    resultSet.Add(element);
                }
            }

            //print the result;
            foreach (var element in resultSet)
            {
                Console.Write("{0} ", element);
            }
        }
    }
}
