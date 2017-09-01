namespace Filter_Students_by_Email_Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FilterStudentsByEmailDomain
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

            //print student with specific email;
            students.Where(x => x[2].EndsWith("@gmail.com"))
                .ToList()
                .ForEach(x => Console.WriteLine("{0} {1}", x[0], x[1]));
        }
    }
}
