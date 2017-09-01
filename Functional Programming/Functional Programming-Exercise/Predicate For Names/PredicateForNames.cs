namespace Predicate_For_Names
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class PredicateForNames
    {
        public static void Main(string[] args)
        {
            //read the name lenght;
            var nameLength = int.Parse(Console.ReadLine());

            //read the names;
            var names = Console.ReadLine()
                .Split(' ')
                .ToArray();

            //predicate for name lenght;
            Predicate<string> lessLenght = x => x.Length <= nameLength;

            foreach (var name in names)
            {
                if (lessLenght(name))
                {
                    Console.WriteLine("{0} ", name);
                }
            }

        }
    }
}
