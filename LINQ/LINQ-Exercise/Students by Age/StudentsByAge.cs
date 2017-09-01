namespace Students_by_Age
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class StudentsByAge
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

            //print students by age;
            students.Where(x => int.Parse(x[2]) >= 18 && int.Parse(x[2]) <= 24)
                .Select(x => $"{x[0]} {x[1]} {x[2]}")
                .ToList()
                .ForEach(x => Console.WriteLine(x));
        }
    }
}
