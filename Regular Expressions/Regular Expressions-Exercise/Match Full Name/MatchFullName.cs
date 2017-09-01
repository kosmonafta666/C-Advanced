namespace Match_Full_Name
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class MatchFullName
    {
        public static void Main(string[] args)
        {
            //string for regex;
            var regex = new Regex("[A-Z][a-z]+? [A-Z][a-z]+");

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
