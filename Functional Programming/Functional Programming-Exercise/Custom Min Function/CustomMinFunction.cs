namespace Custom_Min_Function
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class CustomMinFunction
    {
        static void Main(string[] args)
        {
            //read the input numbers;
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            Func<int[], int> minNumber = x => x.Min();

            Console.WriteLine(minNumber(numbers));
        }

    }
}
