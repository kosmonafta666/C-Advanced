namespace Students_by_Group
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StudentsByGroup
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

            //print the names by group 2;
            names.Where(x => x[2] == "2")
                .OrderBy(x => x[0])
                .ToList()
                .ForEach(x => Console.WriteLine("{0} {1}", x[0], x[1]));
        }
    }
}
