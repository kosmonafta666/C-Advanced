namespace Formatting_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FormattingNumbers
    {
        public static void Main(string[] args)
        {
            //read the input numbers;
            var numbers = Console.ReadLine()
                .Split((char[])null, StringSplitOptions.RemoveEmptyEntries);

            //var for first number;
            var firstNumber = int.Parse(numbers[0]);

            //asign string for binary of first number;
            var firstToBinary = Convert.ToString(firstNumber, 2);

            if (firstToBinary.Length > 10)
            {
                firstToBinary = firstToBinary.Substring(0, 10);
            }
            else
            {
                firstToBinary = firstToBinary.PadLeft(10, '0');
            }

            //var for second number;
            var secondNumber = double.Parse(numbers[1]);

            //var for third number;
            var thirdNumber = double.Parse(numbers[2]);

            //printing the result;
            Console.WriteLine("|{0, -10}|{1, 10}|{2,10:F2}|{3,-10:F3}|"
                , Convert.ToString(firstNumber, 16).ToUpper()
                , firstToBinary
                , secondNumber
                , thirdNumber);
        }
    }
}
