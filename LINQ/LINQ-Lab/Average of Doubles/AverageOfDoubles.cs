namespace Average_of_Doubles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class AverageOfDoubles
    {
        public static void Main(string[] args)
        {
            //read the input numbers;
            var doubles = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            //print the result;
            Console.WriteLine("{0:F2}", doubles.Average());
        }
    }
}
