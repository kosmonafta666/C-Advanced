namespace String_Length
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StringLength
    {
        public static void Main(string[] args)
        {
            //read the input string;
            var inputStr = Console.ReadLine();

            //take only 20 characters;
            inputStr = new string(inputStr.Take(20).ToArray());

            //string for result;
            var result = inputStr.PadRight(20, '*');

            //print the result;
            Console.WriteLine(result);
        }
    }
}
