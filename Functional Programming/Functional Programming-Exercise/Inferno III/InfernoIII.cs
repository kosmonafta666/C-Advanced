namespace Inferno_III
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class InfernoIII
    {
        private static List<int> gems;

        public static void Main(string[] args)
        {
            //read the gems;
            gems = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            //list for filters;
            var filters = new Dictionary<string, Dictionary<int, Predicate<int>>>();

            //read the commands;
            var command = Console.ReadLine();

            while (command != "Forge")
            {
                //var for splited command;
                var token = command
                    .Split(';');
 
                //var for action;
                var action= token[0];
               
                //var for filter type;
                var filterType = token[1];

                //var for filter parametar;
                var filterParam = int.Parse(token[2]);

                //fill the filter dictionary;
                if (action == "Exclude")
                {
                    //predicate for filter type;
                    var filterFunc = GetPredicate(filterType, filterParam);

                    if (!filters.ContainsKey(filterType))
                    {
                        filters.Add(filterType, new Dictionary<int, Predicate<int>>());
                    }

                    filters[filterType].Add(filterParam, filterFunc);
                }
                else
                {
                    filters[filterType].Remove(filterParam);
                }            

                command = Console.ReadLine();
            }//end of while loop;

            //filtering the gems;
            gems = Filter(filters);

            //print the result;
            Console.WriteLine("{0}", string.Join(" ", gems));
        }

        //method that filter gems and return new list;
        private static List<int> Filter(Dictionary<string, Dictionary<int, Predicate<int>>> filters)
        {
            var result = new List<int>();

            for (int i = 0; i < gems.Count; i++)
            {              
                var isFiltered = false;

                foreach (var filter in filters)
                {
                    foreach (var predicate in filter.Value)
                    {
                        if (predicate.Value(i))
                        {
                            isFiltered = true;
                            break;
                        }
                    }
                }

                if (!isFiltered)
                {
                    result.Add(gems[i]);
                }
            }

            return result;
        }

        //method that return predicate for every type filter;
        private static Predicate<int> GetPredicate(string filterType, int filterParam)
        {
            switch (filterType)
            {
                case "Sum Left":
                    return i => (i <= 0 ? 0 : gems[i - 1]) + gems[i] == filterParam;
                case "Sum Right":
                    return i => gems[i] + (i >= gems.Count - 1 ? 0 : gems[i + 1]) == filterParam;
                case "Sum Left Right":
                    return i => (i <= 0 ? 0 : gems[i - 1]) + gems[i] +
                        (i >= gems.Count - 1 ? 0 : gems[i + 1]) == filterParam;
            }

            return null;
        }
    }
}
