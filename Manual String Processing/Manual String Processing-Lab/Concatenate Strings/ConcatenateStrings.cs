namespace Concatenate_Strings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ConcatenateStrings
    {
        public static void Main(string[] args)
        {
            //read the number of strings;
            var n = int.Parse(Console.ReadLine());

            //var for result strng builder;
            var resultStr = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                //read the current string;
                var currentStr = Console.ReadLine();

                resultStr.Append(currentStr);
                resultStr.Append(" ");
            }

            Console.WriteLine("{0}", resultStr);
        }
    }
}
