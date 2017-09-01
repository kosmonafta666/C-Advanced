namespace CountSameValuesInArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class CountSameValuesInArray
    {
        public static void Main(string[] args)
        {
            //read the input of doubles;
            var doubles = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            //sorted dictionary for result;
            var resultDict = new SortedDictionary<double, int>();

            //fill the dictionary result;
            foreach (var num in doubles)
            {
                if (!resultDict.ContainsKey(num))
                {
                    resultDict.Add(num, 1);
                }
                else
                {
                    resultDict[num]++;
                }
            }

            //print the result;
            foreach (var item in resultDict)
            {
                Console.WriteLine("{0} - {1} times", item.Key, item.Value);
            }
        }
    }
}
