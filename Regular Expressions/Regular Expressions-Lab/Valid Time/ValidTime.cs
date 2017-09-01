namespace Valid_Time
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;


    public class ValidTime
    {
        public static void Main(string[] args)
        {
            //read the input date;
            var input = Console.ReadLine();

            //string for pattern;
            var pattern = @"^([0-1][0-9]:[0-5][0-9]:[0-5][0-9]) (A|P)M$";

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
