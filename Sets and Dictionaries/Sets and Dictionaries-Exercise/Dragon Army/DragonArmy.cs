namespace Dragon_Army
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DragonArmy
    {
        public static void Main(string[] args)
        {
            //dictionary for dragons;
            var dragons = new Dictionary<string, SortedDictionary<string, int[]>>();

            //read the number of dragons;
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                //var for current dragon;
                var dragon = Console.ReadLine()
                    .Split(' ');

                //var for dragon type;
                var type =dragon[0];
                //var for dragon name;
                var name = dragon[1];

                //var for damage;
                var damage = dragon[2].Equals("null") ? 45 : int.Parse(dragon[2]);
                //var for health;
                var health = dragon[3].Equals("null") ? 250 : int.Parse(dragon[3]);
                //var for armour;
                var armour = dragon[4].Equals("null") ? 10 : int.Parse(dragon[4]);

                //fill the dragon dictionary;
                if (!dragons.ContainsKey(type))
                {
                    dragons.Add(type, new SortedDictionary<string, int[]>());

                    dragons[type][name] = new int[] { damage, health, armour };
                }
                else
                {
                    if (!dragons[type].ContainsKey(name))
                    {
                        dragons[type].Add(name, new int[3]);

                        dragons[type][name] = new int[] { damage, health, armour };
                    }
                    else
                    {
                        dragons[type][name] = new int[] { damage, health, armour };
                    }
                }
            }//end of for loop;

            //print the result;
            foreach (var type in dragons)
            {
                //var for average type damage;
                var averageDamage = type.Value.Values.Average(x => x[0]);
                //var for average type health;
                var averageHealth = type.Value.Values.Average(x => x[1]);
                //var for average type armour;
                var averageArmour = type.Value.Values.Average(x => x[2]);

                Console.WriteLine($"{type.Key}::({averageDamage:F2}/{averageHealth:F2}/{averageArmour:F2})");

                foreach (var dragon in type.Value)
                {
                    Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value[0]}, health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
                }
            }
        }
    }
}
