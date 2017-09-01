namespace Students_Results
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StudentsResults
    {
        public static void Main(string[] args)
        {
            //read the number of students;
            var n = int.Parse(Console.ReadLine());

            //string for header;
            string header = String
                .Format("{0,-10}|{1,7}|{2,7}|{3,7}|{4,7}|", "Name", "CAdv", "COOP", "AdvOOP", "Average");

            Console.WriteLine(header);

            for (int i = 1; i <= n; i++)
            {
                //read the current student;
                var token = Console.ReadLine()
                    .Split(new[] { ' ', '-', ',' }, StringSplitOptions.RemoveEmptyEntries);

                //var for student name;
                var name = token[0];
                //var for first result;
                var firstNum = double.Parse(token[1]);
                //var for second result;
                var secondNum = double.Parse(token[2]);
                //var for third result;
                var thirdNum = double.Parse(token[3]);
                //var for average grade;
                var average = (firstNum + secondNum + thirdNum) / 3;

                //string for grades of the current student;
                string grades = String
                    .Format("{0,-10}|{1,7:F2}|{2,7:F2}|{3,7:F2}|{4,7:F4}|", name, firstNum, secondNum, thirdNum, average);

                Console.WriteLine(grades);
            }
        }
    }
}
