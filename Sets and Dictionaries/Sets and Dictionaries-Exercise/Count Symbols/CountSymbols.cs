namespace Count_Symbols
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CountSymbols
    {
        public static void Main(string[] args)
        {
            //read the input string;
            var inputString = Console.ReadLine();

            //dictionary for result;
            var resultDict = new SortedDictionary<char, int>();

            //fill the result dictionary;
            foreach (var ch in inputString)
            {
                if (!resultDict.ContainsKey(ch))
                {
                    resultDict.Add(ch, 1);
                }
                else
                {
                    resultDict[ch]++;
                }
            }

            //print the result;
            foreach (var item in resultDict)
            {
                Console.WriteLine("{0}: {1} time/s", item.Key, item.Value);
            }
        }
    }
}
