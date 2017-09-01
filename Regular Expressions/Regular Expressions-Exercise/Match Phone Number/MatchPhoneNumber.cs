namespace Match_Phone_Number
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class MatchPhoneNumber
    {
        public static void Main(string[] args)
        {
            //string for regex;
            var regex = new Regex(@"^\+359( |-)2\1\d{3}\1\d{4}$");

            //read the input;
            var input = Console.ReadLine();

            while (input != "end")
            {
                if (regex.IsMatch(input))
                {
                    Console.WriteLine(input);
                }

                input = Console.ReadLine();
            }
        }
    }
}
