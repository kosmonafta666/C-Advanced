namespace AcademyGraduation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AcademyGraduation
    {
        public static void Main(string[] args)
        {
            //read the number of students;
            var n = int.Parse(Console.ReadLine());

            //dictionary for studends;
            var students = new SortedDictionary<string, List<double>>();

            for (int i = 1; i <= n; i++)
            {
                //var for name of the student;
                var name = Console.ReadLine();
                //list for scores of the student;
                var scores = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToList();
                
                //fill the students dictionary;
                if (!students.ContainsKey(name))
                {
                    students.Add(name, new List<double>());
                }

                students[name] = scores;
            }

            //print the result;
            foreach (var student in students)
            {
                Console.WriteLine("{0} is graduated with {1}", student.Key, student.Value.Average());
            }
        }
    }
}
