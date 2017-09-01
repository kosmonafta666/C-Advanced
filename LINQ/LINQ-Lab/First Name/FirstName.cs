namespace First_Name
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FirstName
    {
        public static void Main(string[] args)
        {
            //read the input and convert to string array;
            var input = Console.ReadLine()
                .Split(' ')
                .ToList();

            //read the characters, convert to char list and make to upper;
            var characters = Console.ReadLine()
                .Split(' ')
                .OrderBy(x => x)
                .ToList();


            foreach (var ch in characters)
            {
                //var for first match;
                var result = input.Where(x => x.ToLower().StartsWith(ch.ToLower()))
                    .FirstOrDefault();

                //if found match print and exit;
                if (result != null)
                {
                    Console.WriteLine(result);
                    return;
                }             
           
            }

            //if not found match print it;
            Console.WriteLine("No match");
        }
    }
}
