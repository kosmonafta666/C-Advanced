namespace Cubic_Assault
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CubicAssault
    {
        public static int ConvertThresHold = 1_000_000;

        public static void Main(string[] args)
        {
            //dictionary for regions;
            var regions = new Dictionary<string, Dictionary<string, long>>();

            //list for meteor names to updating meteors count;
            var meteorNames = new List<string>() { "Green", "Red", "Black" };

            //read the meteors;
            var command = "";

            while ((command = Console.ReadLine()) != "Count em all")
            {
                //var for splitted command;
                var token = command
                    .Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                //var for region names;
                var regionName = token[0];

                //var for region type;
                var regionType = token[1];

                //var for meteor count;
                var meteorCount = int.Parse(token[2]);

                //fill the dictionary;
                if (!regions.ContainsKey(regionName))
                {
                    regions.Add(regionName, new Dictionary<string, long>()
                    {
                        {"Green", 0},
                        {"Red", 0 },
                        {"Black", 0 }
                    });
                }

                regions[regionName][regionType] += meteorCount;


                //update the meteors count;
                /*for (int i = 0; i < meteorNames.Count - 1; i++)
                {
                    var nextTypeCount = regions[regionName][meteorNames[i]] / ConvertThresHold;

                    if (nextTypeCount > 0)
                    {
                        regions[regionName][meteorNames[i + 1]] += nextTypeCount;
                        regions[regionName][meteorNames[i]] %= ConvertThresHold;
                    }
                }*/

                if (regions[regionName]["Green"] >= ConvertThresHold)
                {
                    regions[regionName]["Red"] += regions[regionName]["Green"] / ConvertThresHold;
                    regions[regionName]["Green"] %= ConvertThresHold;
                }

                if (regions[regionName]["Red"] >= ConvertThresHold)
                {
                    regions[regionName]["Black"] += regions[regionName]["Red"] / ConvertThresHold;
                    regions[regionName]["Red"] %= ConvertThresHold;
                }

            }//end of while loop;

            //dictionary for sorted regions;
            var sortedRegions = regions
                .OrderByDescending(x => x.Value["Black"])
                .ThenBy(x => x.Key.Length)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            //print the result;
            foreach (var region in sortedRegions)
            {
                Console.WriteLine("{0}", region.Key);

                foreach (var type in region.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine("-> {0} : {1}", type.Key, type.Value);
                }
            }
        }
    }
}
