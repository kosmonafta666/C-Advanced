namespace Excellent_Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ExcellentStudents
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

            //print students with at least one 6 mark;
            students.Where(x => x.Skip(2).Any(mark => int.Parse(mark) == 6))
                .ToList()
                .ForEach(x => Console.WriteLine("{0} {1}", x[0], x[1]));
        }
    }
}
