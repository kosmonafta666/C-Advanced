namespace Filter_By_Age
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FilterByAge
    {
        public static void Main(string[] args)
        {
            //dictionary for persons;
            var persons = new Dictionary<string, int>();

            //read the number of persons;
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                //read the current person;
                var currentPerson = Console.ReadLine()
                    .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                //var for name;
                var name = currentPerson[0];
                //var for age;
                var agePerson = int.Parse(currentPerson[1]);

                //fill the dictionary;
                if (!persons.ContainsKey(name))
                {
                    persons.Add(name, agePerson);
                }
            }//end of reading the persons;

            //read the condition;
            var condition = Console.ReadLine();
            //read the age;
            var age = int.Parse(Console.ReadLine());
            //read the format;
            var format = Console.ReadLine();

            Func<int, bool> tester = CreateTester(condition, age);

            Action<KeyValuePair<string, int>> printer = CreatePrinter(format);

            InvokePeople(persons, tester, printer);
        }

        private static void InvokePeople(Dictionary<string, int> persons, Func<int, bool> tester, Action<KeyValuePair<string, int>> printer)
        {
            foreach(var person in persons)
            {
                if (tester(person.Value))
                {
                    printer(person);
                }
            }
        }

        private static Action<KeyValuePair<string, int>> CreatePrinter(string format)
        {
            switch(format)
            {
                case "name age":
                    return p => Console.WriteLine($"{p.Key} - {p.Value}");
                case "name":
                    return p => Console.WriteLine($"{p.Key}");
                case "age":
                    return p => Console.WriteLine($"{p.Value}");
                default:
                    return null;
            }

        }

        private static Func<int, bool> CreateTester(string condition, int age)
        {
            if (condition == "older")
            {
                return n => n >= age;
            }
            else
            {
                return n => n <= age;
            }
        }
    }
}
