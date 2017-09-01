namespace SoftUniParty
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SoftUniParty
    {
        public static void Main(string[] args)
        {
            //sorted hash for quest;
            var guests = new SortedSet<string>();

            //read the first input for reserve list;
            var reserve = Console.ReadLine();

            while (reserve != "PARTY")
            {
                guests.Add(reserve);

                reserve = Console.ReadLine();
            }

            //read the guest who is comming;
            var comming = Console.ReadLine();

            while (comming != "END")
            {
                if (guests.Contains(comming))
                {
                    guests.Remove(comming);
                }

                comming = Console.ReadLine();
            }

            //printing the result;
            Console.WriteLine(guests.Count);

            foreach (var guest in guests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
