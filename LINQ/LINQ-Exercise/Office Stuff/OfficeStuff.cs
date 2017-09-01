namespace Office_Stuff
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class OfficeStuff
    {
        public static void Main(string[] args)
        {
            //dictionary for office stuff;
            var officeStuf = new Dictionary<string, Dictionary<string, int>>();

            //read the number of input lines;
            var n = int.Parse(Console.ReadLine());

            //read the office stuff;
            for (int i = 1; i <= n; i++)
            {
                //read the current input line and splitted;
                var inputLine = Console.ReadLine()
                    .Split(new[] { '|', ' ', '-' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                //var for company;
                var company = inputLine[0];

                //var for office count;
                var count = int.Parse(inputLine[1]);

                //var for office stuff;
                var stuff = inputLine[2];

                //fill the office dictionary;
                if(!officeStuf.ContainsKey(company))
                {
                    officeStuf.Add(company, new Dictionary<string, int>());
                    
                    if (!officeStuf[company].ContainsKey(stuff))
                    {
                        officeStuf[company].Add(stuff, count);
                    }
                }
                else
                {
                    if (!officeStuf[company].ContainsKey(stuff))
                    {
                        officeStuf[company].Add(stuff, count);
                    }
                    else
                    {
                        officeStuf[company][stuff] += count;
                    }
                }

            }//end of reading the office stuff;

            //print the result;
            foreach (var item in officeStuf.OrderBy(x => x.Key))
            {
                Console.Write("{0}: ", item.Key);

                //create kvp from value of current company;
                var kvp = item.Value
                    .Select(x => $"{x.Key}-{x.Value}")
                    .ToList();

                //print it;
                Console.WriteLine("{0}", string.Join(", ", kvp));

            }
        }
    }
}
