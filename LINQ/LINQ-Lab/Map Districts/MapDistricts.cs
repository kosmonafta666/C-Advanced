namespace Map_Districts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MapDistricts
    {
        public static void Main(string[] args)
        {
            //read the input string;
            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            //read the bound number;
            var bound = long.Parse(Console.ReadLine());

            //dictionary for result;
            var result = new Dictionary<string, List<long>>();

            foreach (var str in input)
            {
                //var for city;
                var city = str.Split(':')[0];
                //var for population;
                var population = long.Parse(str.Split(':')[1]);

                //fill the dictionary;
                if (!result.ContainsKey(city))
                {
                    result.Add(city, new List<long>());
                    result[city].Add(population);
                }
                else
                {
                    result[city].Add(population);
                }
            }

            //extract cities by bound criteria and sort them by population;
            result = result
                .Where(x => x.Value.Sum() >= bound)
                .OrderByDescending(x => x.Value.Sum())
                .ToDictionary(x => x.Key, x => x.Value);

            //print the result;
            foreach (var item in result)
            {
                Console.Write("{0}: ", item.Key);

                Console.Write("{0}", string.Join(" ", item.Value.OrderByDescending(x => x).Take(5)));

                Console.WriteLine();
            }
        }
    }
}
