namespace Valid_Usernames
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class ValidUsernames
    {
        public static void Main(string[] args)
        {
            //read the input;
            var input = Console.ReadLine();

            //string for pattern;
            var pattern = @"^[\w-]{3,16}$";

            //var for regex;
            var regex = new Regex(pattern);

            while (input != "END")
            {              
                if (regex.IsMatch(input))
                {
                    Console.WriteLine("valid");
                }
                else
                {
                    Console.WriteLine("invalid");
                }

                input = Console.ReadLine();
            }
        }
    }
}
