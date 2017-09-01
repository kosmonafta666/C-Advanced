namespace FilterStudentsByPhone
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FilterStudentsByPhone
    {
        public static void Main(string[] args)
        {
            //list for names;
            var names = new List<string[]>();

            //read the input;
            var input = Console.ReadLine();

            while (input != "END")
            {
                //var for spitted input line;
                var token = input
                    .Split(' ')
                    .ToArray();

                names.Add(token);

                input = Console.ReadLine();
            }//end of while loop;

            //print the names with specific prefix number;
            names.Where(x => x[2].StartsWith("02") || x[2].StartsWith("+3592"))
                .Select(x => $"{x[0]} {x[1]}")
                .ToList()
                .ForEach(x => Console.WriteLine(x));
        }
    }
}
