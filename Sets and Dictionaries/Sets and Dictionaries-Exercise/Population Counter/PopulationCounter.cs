namespace Population_Counter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PopulationCounter
    {
        public static void Main(string[] args)
        {
            //dictionary for population;
            var population = new Dictionary<string, Dictionary<string, long>>();

            //read the input;
            var input = Console.ReadLine();

            while (input != "report")
            {
                //var for splitted input;
                var token = input
                    .Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

                //var for country;
                var country = token[1];
                //var for city;
                var city = token[0];
                //var for population;
                var people = long.Parse(token[2]);

                //fill the dictionary;
                if (!population.ContainsKey(country))
                {
                    population.Add(country, new Dictionary<string, long>());

                    population[country][city] = people;
                }
                else
                {
                    if (!population[country].ContainsKey(city))
                    {
                        population[country][city] = people;
                    }
                    else
                    {
                        population[country][city] += people;
                    }
                }

                input = Console.ReadLine();
            }//end of while loop;

            //printing the result;
            foreach (var country in population
                .OrderByDescending(x => x.Value.Values.Sum()))
            {
                //var for all peaple in country;
                var allPeople = country.Value.Values.Sum();

                Console.WriteLine($"{country.Key} (total population: {allPeople})");

                //printing the cities;
                foreach (var city in country.Value
                    .OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
