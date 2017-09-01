namespace Students_by_First_and_Last_Name
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StudentsByFirstAndLastName
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

            //print the names by givven criteria;
            names.Where(x => String.Compare(x[0], x[1]) == -1)
                .ToList()
                .ForEach(x => Console.WriteLine("{0} {1}", x[0], x[1]));
        }
    }
}
