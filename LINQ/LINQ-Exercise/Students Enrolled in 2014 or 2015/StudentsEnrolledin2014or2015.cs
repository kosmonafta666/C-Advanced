namespace Students_Enrolled_in_2014_or_2015
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StudentsEnrolledin2014or2015
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

            //print the students from 2014 and 2015;
            students.Where(x => x[0].EndsWith("14") || x[0].EndsWith("15"))
                .Select(x => $"{string.Join(" ", x.Skip(1))}")
                .ToList()
                .ForEach(x => Console.WriteLine(x));
        }
    }
}
