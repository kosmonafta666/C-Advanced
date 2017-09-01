namespace Group_by_Group
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Person
    {
        private string name;

        private int group;

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        public int Group
        {
            get { return group; }
            set { this.group = value; }
        }

        public Person (string name, int group)
        {
            this.Name = name;
            this.Group = group;
        }
    }

    public class GroupByGroup
    {
        public static void Main(string[] args)
        {
            //list for persons;
            var persons = new List<Person>();

            //read the input;
            var input = Console.ReadLine();

            while (input != "END")
            {
                //var for splitted input;
                var token = input.Split(' ');

                //var for name;
                var name = String.Format("{0} {1}", token[0], token[1]);
                //var for group;
                var group = int.Parse(token[2]);

                //var for current person;
                var currentPerson = new Person(name, group);

                persons.Add(currentPerson);

                input = Console.ReadLine();

            }//end of while loop;

            //print persons by group;
            persons.GroupBy(x => x.Group, x => x.Name)
                .OrderBy(x => x.Key)
                .Select(x => $"{x.Key} - {string.Join(", ", x.ToList())}")
                .ToList()
                .ForEach(x => Console.WriteLine(x));
        }
    }
}
