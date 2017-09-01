namespace TriFunction
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TriFunction
    {
        public static void Main(string[] args)
        {
            //read the matching number;
            var number = int.Parse(Console.ReadLine());

            //read the input string and split it;
            var names = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            //func that check if sum of characters is bigger or equal to number;
            Func<string, int, bool> checkName = (x, y) =>
                    x.Select(s => (int)s).ToList().Sum() >= y;

            //print the matching name;
            PrintNumber(names, number, checkName);
        }

        //method that print matching name;
        private static void PrintNumber(List<string> names, int number, Func<string, int, bool> checkName)
        {
            foreach (var name in names)
            {
                if (checkName(name, number))
                {
                    Console.WriteLine(name);
                    break;
                }
            }
        }
    }

}
