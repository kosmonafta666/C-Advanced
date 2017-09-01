namespace Cubic_Artillery
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CubicArtillery
    {
        public static void Main(string[] args)
        {
            //read the capacity of the bunkers
            var capacity = int.Parse(Console.ReadLine());

            //queue for current bunkers;
            var bunkers = new Queue<string>();

            //queue for weapons
            var weapons = new Queue<int>();

            //var for left capacity;
            var leftCapacity = capacity;

            var input = "";

            while ((input = Console.ReadLine()) != "Bunker Revision")
            {
                //var for splitted input;
                var tokens = input.Split(' ');

                foreach (var token in tokens)
                {
                    //var for current weapon;
                    int weapon = 0;

                    var isDigit = int.TryParse(token, out weapon);

                    if (!isDigit)
                    {
                        bunkers.Enqueue(token);
                    }
                    else
                    {

                        var isSaved = false;

                        while (bunkers.Count > 1)
                        {
                            if (leftCapacity >= weapon)
                            {
                                weapons.Enqueue(weapon);

                                leftCapacity -= weapon;

                                isSaved = true;

                                break;
                            }

                            var removedBunker = bunkers.Dequeue();

                            if (weapons.Count == 0)
                            {
                                Console.WriteLine("{0} -> Empty", removedBunker);
                            }
                            else
                            {
                                Console.WriteLine("{0} -> {1}", removedBunker, string.Join(", ", weapons));
                            }

                            weapons.Clear();

                            leftCapacity = capacity;
                        }//end of while loop;

                        if (!isSaved)
                        {
                            if (weapon <= capacity)
                            {
                                while (leftCapacity < weapon)
                                {
                                    leftCapacity += weapons.Dequeue();
                                }

                                weapons.Enqueue(weapon);

                                leftCapacity -= weapon;
                            }
                        }
                    }
                }//end of foreach loop;
            }
        }
    }
}
