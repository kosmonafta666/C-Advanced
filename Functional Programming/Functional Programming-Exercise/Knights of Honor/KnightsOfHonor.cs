namespace Knights_of_Honor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class KnightsOfHonor
    {
        public static void Main(string[] args)
        {
            //read the input string
            var inputStr = Console.ReadLine()
                .Split(' ')
                .ToArray();

            //action to print name with SIR;
            Action<string> printKnights = x => Console.WriteLine("Sir {0}", x);

            //print the result;
            foreach (var name in inputStr)
            {
                printKnights(name);
            }
        }
    }
}
