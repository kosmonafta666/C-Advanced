namespace Unique_Usernames
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class UniqueUsernames
    {
        public static void Main(string[] args)
        {
            //read the number of user names;
            var n = int.Parse(Console.ReadLine());

            //hash set for unique usernames;
            var userNames = new HashSet<string>();

            for (int i = 1; i <= n; i++)
            {
                //var for current username;
                var currentUserName = Console.ReadLine();

                //add to usernames hash set;
                userNames.Add(currentUserName);
            }

            //print the result;
            foreach (var userName in userNames)
            {
                Console.WriteLine(userName);
            }
        }
    }
}
