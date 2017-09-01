namespace Logs_Aggregator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LogsAggregator
    {
        public static void Main(string[] args)
        {
            //dictionary for users;
            var users = new Dictionary<string, Dictionary<string, int>>();

            //read the number of users;
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                //var for input commands;
                var input = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                //var for users name;
                var name = input[1];
                //var for ip address;
                var ip = input[0];
                //var for duration;
                var duration = int.Parse(input[2]);

                //fill the users dictionary;
                if (!users.ContainsKey(name))
                {
                    users.Add(name, new Dictionary<string, int>());

                    users[name].Add(ip, duration);
                }
                else
                {
                    if (!users[name].ContainsKey(ip))
                    {
                        users[name].Add(ip, duration);
                    }
                    else
                    {
                        users[name][ip] += duration;
                    }
                }
            }

            //printing the result;
            foreach (var user in users.OrderBy(x => x.Key))
            {
                //var for total duration for current user;
                var totalDuration = user.Value.Values.Sum();

                Console.WriteLine($"{user.Key}: {totalDuration} " +
                    $"[{string.Join(", ", user.Value.OrderBy(x => x.Key).Select(x => x.Key))}]");
            }

        }
    }
}
