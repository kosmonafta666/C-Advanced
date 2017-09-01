namespace Sort_Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SortStudents
    {
        public static void Main(string[] args)
        {
            //list for names;
            var students = new List<string[]>();

            //read the input;
            var input = Console.ReadLine();

            while (input != "END")
            {
                //var for spitted input line;
                var token = input
                    .Split(' ')
                    .ToArray();

                students.Add(token);

                input = Console.ReadLine();
            }//end of while loop;

            //print students oreding by last name the then first;
            students.OrderBy(x => x[1])
                .ThenByDescending(x => x[0])
                .ToList()
                .ForEach(x => Console.WriteLine("{0} {1}", x[0], x[1]));

        }
    }
}
