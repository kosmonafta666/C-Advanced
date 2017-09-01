namespace Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Phonebook
    {
        public static void Main(string[] args)
        {
            //dictionary for phonebook;
            var phoneBook = new Dictionary<string, string>();

            //read the phone;
            var phone = Console.ReadLine();

            while (phone != "search")
            {
                //var for splitted phone;
                var token = phone
                    .Split('-');

                //var for name;
                var name = token[0];
                //var for number;
                var number = token[1];

                //fill the dictionary phonebook;
                if (!phoneBook.ContainsKey(name))
                {
                    phoneBook.Add(name, number);
                }
                else
                {
                    phoneBook[name] = number;
                }

                phone = Console.ReadLine();
            }//end of first while loop;

            //read the search name;
            var searchName = Console.ReadLine();

            while (searchName != "stop")
            {
                //check for search name and print the result;
                if (phoneBook.ContainsKey(searchName))
                {
                    Console.WriteLine("{0} -> {1}", searchName, phoneBook[searchName]);
                }
                else
                {
                    Console.WriteLine("Contact {0} does not exist.", searchName);
                }

                searchName = Console.ReadLine();
            }//end of second while loop;
        }
    }
}
