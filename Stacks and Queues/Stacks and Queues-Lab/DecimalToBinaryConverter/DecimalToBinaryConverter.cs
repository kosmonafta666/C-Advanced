namespace DecimalToBinaryConverter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DecimalToBinaryConverter
    {
        public static void Main(string[] args)
        {
            //read the number to convert;
            var inputNumber = int.Parse(Console.ReadLine());

            //stack for result;
            var resultStack = new Stack<int>();

            if (inputNumber == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                //var for remainder;
                var remainder = 0;

                while (inputNumber != 0)
                {
                    //extract the remainder and push to result stack;
                    remainder = inputNumber % 2;
                    resultStack.Push(remainder);
                    //divide the number by 2 again;
                    inputNumber = inputNumber / 2;                  
                }
            }

            //print the result;
            Console.WriteLine(string.Join("", resultStack));
        }
    }
}
