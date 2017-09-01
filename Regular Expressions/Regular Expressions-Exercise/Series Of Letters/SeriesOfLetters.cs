namespace Series_Of_Letters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class SeriesOfLetters
    {
        public static void Main(string[] args)
        {
            //read the input string;
            var inputStr = Console.ReadLine();

            var result = Regex.Replace(inputStr, "([A-Za-z])\\1+", "$1");

            Console.WriteLine(result);
        }
    }
}
