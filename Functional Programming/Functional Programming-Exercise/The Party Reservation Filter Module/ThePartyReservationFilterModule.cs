namespace The_Party_Reservation_Filter_Module
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ThePartyReservationFilterModule
    {
        public static void Main(string[] args)
        {
            //read the names;
            var names = Console.ReadLine()
                .Split(' ')
                .ToList();

            //list for filtered names;
            var filterCommands = new List<string>();

            //func that return list by given criteria;
            Func<List<string>, string, string, List<string>> filterFunc = 
                (sourceList, condition, sub) =>
            {
                if (condition == "Starts with")
                {
                    return sourceList.Where(p => !p.StartsWith(sub)).ToList();
                }
                else if (condition == "Ends with")
                {
                    return sourceList.Where( p => !p.EndsWith(sub)).ToList();
                }
                else if (condition == "Contains")
                {
                    return sourceList.Where( p => !p.Contains(sub)).ToList();
                }
                else
                {
                    return sourceList.Where( p => p.Length.Equals(int.Parse(sub))).ToList();
                }
            };


            //read the command;
            var command = Console.ReadLine();

            while (command != "Print")
            {
                //var for splited command;
                var token = command
                    .Split(';')
                    .ToList();

                //var for action filter;
                var actionFilter = token[0];
                //var for condition;
                var condition = token[1];
                //var for condition operator;
                var conditionOperator = token[2];

                //add or remove condition and condition operator form filter list;
                if (actionFilter == "Add filter")
                {
                    filterCommands.Add(condition + ";" + conditionOperator);
                }
                else if (actionFilter == "Remove filter")
                {
                    filterCommands.Remove(condition + ";" + conditionOperator);
                }
                command = Console.ReadLine();

            }//end of while loop;

            //change the names list by givven filter;
            foreach (var filter in filterCommands)
            {
                //split filter command to condition and condition operator;
                var condition = filter.Split(';')[0];

                var conditionOperator = filter.Split(';')[1];

                //change the names list;
                names = filterFunc(names, condition, conditionOperator);
            }

            //print the result;
            Console.WriteLine("{0}", string.Join(" ", names));

        }
    }
}