namespace Reverse_String
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ReverseString
    {
        public static void Main(string[] args)
        {
            //read the input string;
            var inputStr = Console.ReadLine();

            //var for string builder;
            var reverseString = new StringBuilder();

            for (int i = inputStr.Length - 1; i >= 0; i--)
            {
                reverseString.Append(inputStr[i]);
            }

            Console.WriteLine(reverseString);
        }
    }
}
