namespace SimpleCalculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SimpleCalculator
    {
        public static void Main(string[] args)
        {
            //read the input string;
            var inputString = Console.ReadLine()
                .Split(' ')
                .ToArray();

            //stack for input string;
            var calcStack = new Stack<string>(inputString.Reverse());

            //var for final sum;
            var sum = int.Parse(calcStack.Pop());          

            while (calcStack.Count > 0)
            {
                //var for operator;
                var oper = calcStack.Pop();
                //var for number;
                var number = int.Parse(calcStack.Pop());

                switch(oper)
                {
                    case "-":
                        sum -= number;
                        break;
                    case "+":
                        sum += number;
                        break;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
