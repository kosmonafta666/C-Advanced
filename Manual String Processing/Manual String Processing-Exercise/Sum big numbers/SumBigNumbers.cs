namespace Sum_big_numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SumBigNumbers
    {
        public static void Main(string[] args)
        {
            //read the first number and put to stack;
            var firstNumber = new Stack<char>(Console.ReadLine());
            //read the second number and put to stack;
            var secondNumber = new Stack<char>(Console.ReadLine());

            //string builde for result;
            var result = new StringBuilder();

            //var for current sum;
            var sum = 0;

            while (firstNumber.Count != 0 || secondNumber.Count != 0)
            {
                sum = sum / 10;
                
                //check the first stack;
                if (firstNumber.Count != 0)
                {
                    sum += (int)Char.GetNumericValue(firstNumber.Pop());
                }

                //check for second stack;
                if (secondNumber.Count != 0)
                {
                    sum += (int)Char.GetNumericValue(secondNumber.Pop());
                }

                //appent string builder;
                result.Insert(0, sum % 10);
            }

            //if has reminder add it;
            if (sum > 9)
            {
                result.Insert(0, sum / 10);
            }

            //print;
            Console.WriteLine(result.ToString().TrimStart('0'));
        }
    }
}
