namespace Unicode_Characters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class UnicodeCharacters
    {
        public static void Main(string[] args)
        {
            //read the input string and convert to char array;
            var input = Console.ReadLine();

            //list for the result;
            var result = new List<string>();

            foreach (var ch in input)
            {
                //var for current char converted to unicode literal;
                var currentChar = (int)ch;
                //var for current string;
                var currentString = String.Format("\\u{0:x4}", currentChar);
                result.Add(currentString);
            }

            Console.WriteLine(string.Join("", result));
        }
    }
}
