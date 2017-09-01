namespace Convert_from_base_10_to_base_N
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Numerics;

    public class ConvertFromBase10ToBaseN
    {
        public static void Main(string[] args)
        {
            //read the input and convert to int;
            var inputStr = Console.ReadLine()
                .Split(' ')
                .Select(BigInteger.Parse)
                .ToArray();

            //var for base;
            var baseNumber = inputStr[0];
            //var for number;
            var number = inputStr[1];

            //string builder for result;
            var result = new StringBuilder();

            while(number != 0)
            {
                BigInteger remiander = number % baseNumber;

                number = number / baseNumber;

                result.Insert(0, remiander);
            }

            //printing the result;
            Console.WriteLine(result);
        }
    }
}
