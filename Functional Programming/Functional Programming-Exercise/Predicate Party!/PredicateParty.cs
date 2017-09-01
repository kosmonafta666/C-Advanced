namespace Predicate_Party_
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PredicateParty
    {
        public static void Main(string[] args)
        {
            //read the names;
            var names = Console.ReadLine()
                .Split(' ')
                .ToList();


            Func<string, string, string, bool> isExist = (name, par, sub) =>
            {
                if (par == "StartsWith")
                {
                    return name.StartsWith(sub);
                }
                else if (par == "EndsWith")
                {
                    return name.EndsWith(sub);
                }
                else
                {
                    return name.Length.Equals(int.Parse(sub));
                }
            };

            var command = Console.ReadLine();

            while (command != "Party!")
            {
                //split the command;
                var token = command
                    .Split(' ')
                    .ToList();

                //var for action;
                var action = token[0];
                //var for condition;
                var condition = token[1];
                //var for condiotion operator;
                var conditionOperator = token[2];

                //current list for result names;
                var resultNames = new List<string>();

                foreach (var name in names)
                {
                    if (isExist(name, condition, conditionOperator))
                    {
                        switch(action)
                        {
                            case "Double":
                                resultNames.Add(name);
                                resultNames.Add(name);
                                break;
                            case "Remove":
                                //do nothing;
                                break;
                        }
                    }
                    else
                    {
                        resultNames.Add(name);
                    }
                }

                //asign names to current result names;
                names = resultNames;

                command = Console.ReadLine();

            }//end of while loop;

            //print the result;
            if (names.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.WriteLine("{0} are going to the party!", string.Join(", ", names));
            }
        }
    }
}
