namespace WeakStudents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class WeakStudents
    {
        public static void Main(string[] args)
        {
            //list for students;
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

            //print student with at least 2 lower marks;
            students
                .Where(x => x.Skip(2).Count(mark => int.Parse(mark) <= 3) >= 2)
                .Select(x => $"{x[0]} {x[1]}")
                .ToList()
                .ForEach(x => Console.WriteLine(x));
        }
    }
}
