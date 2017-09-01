namespace User_Logs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class UserLogs
    {
        public static void Main(string[] args)
        {
            //dictionary for result;
            var resultDict = new SortedDictionary<string, Dictionary<string, int>>();

            //read the input;
            var input = Console.ReadLine();

            while (input != "end")
            {
                //var for splitted input;
                var token = input
                    .Split(' ');

                //var for user name;
                var userName = token[2]
                    .Replace("user=", "");
                //var for ip;
                var ip = token[0]
                    .Replace("IP=", "");

                //Console.WriteLine("{0} {1}", userName, ip);

                //fill the dictionary;
                if (!resultDict.ContainsKey(userName))
                {
                    resultDict.Add(userName, new Dictionary<string, int>());

                    resultDict[userName][ip] = 1;
                }
                else
                {
                    if (!resultDict[userName].ContainsKey(ip))
                    {
                        resultDict[userName].Add(ip, 1);
                    }
                    else
                    {
                        resultDict[userName][ip]++;
                    }
                }

                input = Console.ReadLine();
            }//end of while loop;

            //printing the result;
            foreach (var user in resultDict)
            {
                Console.WriteLine("{0}: ", user.Key);

                Console.WriteLine("{0}.", 
                    string.Join(", ", user.Value.Select(x => $"{x.Key} => {x.Value}")));
            }
        }
    }
}
