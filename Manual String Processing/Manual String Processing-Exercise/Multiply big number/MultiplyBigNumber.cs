namespace Multiply_big_number
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class MultiplyBigNumber
    {
        public static void Main(string[] args)
        {
            //read the big number;
            var bigNumber = Console.ReadLine().TrimStart('0');
            //read the second number;
            var secondNumber = char.Parse(Console.ReadLine());

            //check for zero number;
            if (bigNumber == "0" || secondNumber == '0' || bigNumber == "")
            {
                Console.WriteLine(0);
                return;
            }

            //stack for big number;
            var stack = new Stack<char>(bigNumber);

            //string builder for result;
            var result = new StringBuilder();

            //var for addition of the product;
            var addition = 0;
            //var for current product;
            var product = 0;
            //var for remainder of the product;
            var remainder = 0;

            while (stack.Count != 0)
            {
                //var for current num from stack;
                var num1 = Char.GetNumericValue(stack.Pop());

                product = (int)(num1 * Char.GetNumericValue(secondNumber)) + addition;
                
                remainder = product % 10;

                addition = product / 10;

                result.Insert(0, remainder);
            }

            //if remains addintion add it to result;
            if (addition != 0)
            {
                result.Insert(0, addition);
            }

            //print the result;
            Console.WriteLine(result);

        }
    }
}
