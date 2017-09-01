namespace Students_Joined_to_Specialties
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StudentSpecialty
    {
        private string specialtyName;

        private int facultyNumber;

        public string SpecialtyName
        {
            get { return specialtyName; }
            set { specialtyName = value; }
        }

        public int FacultyNumber
        {
            get { return facultyNumber; }
            set { facultyNumber = value; }
        }

        public StudentSpecialty (string specialtyName, int facultyNumber)
        {
            this.SpecialtyName = specialtyName;

            this.FacultyNumber = facultyNumber;
        }
    }

    public class Student
    {
        private string studentName;

        private int facultyNumber;

        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; }
        }

        public int FacultyNumber
        {
            get { return facultyNumber; }
            set { facultyNumber = value; }
        }

        public Student (string studentName, int facultyNumber)
        {
            this.StudentName = studentName;

            this.FacultyNumber = facultyNumber;
        }
    }


    public class StudentsJoinedToSpecialties
    {
        public static void Main(string[] args)
        {
            //list for student specialties;
            var specialties = new List<StudentSpecialty>();

            //list for students;
            var students = new List<Student>();

            //read specialties;
            var specsCommand = Console.ReadLine();

            while (specsCommand != "Students:")
            {
                //split specialties command;
                var token = specsCommand.Split(' ');

                //var for specialty name;
                var specName = String.Format("{0} {1}",token[0], token[1]);

                //var for specialty number;
                var specNumber = int.Parse(token[2]);

                //create student specialty instance and add it to list;
                var currentSpec = new StudentSpecialty(specName, specNumber);

                specialties.Add(currentSpec);

                specsCommand = Console.ReadLine();

            }//end of reading the specialties;

            //read the students;
            var studentCommand = Console.ReadLine();

            while (studentCommand != "END")
            {
                //var for splitted student command;
                var token = studentCommand.Split(' ');

                //var for student faculty number;
                var facultyNumber = int.Parse(token[0]);

                //var for student name;
                var studentName = String.Format("{0} {1}", token[1], token[2]);

                //create current student and add it to list;
                var curentStudent = new Student(studentName, facultyNumber);

                students.Add(curentStudent);

                studentCommand = Console.ReadLine();

            }//end of reading the students;

            //join the 2 collection by faculty number;
            var result = specialties
                .Join(students, sp => sp.FacultyNumber, st => st.FacultyNumber
                , (sp, st) => new
                {
                    Name = st.StudentName,
                    FacNum = st.FacultyNumber,
                    Spec = sp.SpecialtyName
                })
                .OrderBy(x => x.Name)
                .ToList();

            //print the result;
            foreach (var item in result)
            {
                Console.WriteLine("{0} {1} {2}", item.Name, item.FacNum, item.Spec);
            }
        }
    }
}
