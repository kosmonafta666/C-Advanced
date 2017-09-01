namespace Legendary_Farming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LegendaryFarming
    {
        public static void Main(string[] args)
        {
            //dictionary for materials;
            var mats = new SortedDictionary<string, int>();

            //add initial key to material dictionary for legendary mats;
            mats.Add("fragments", 0);
            mats.Add("motes", 0);
            mats.Add("shards", 0);

            while (true)
            {
                //bool to break the loop;
                bool flag = false;

                //read the input and splitted;
                var input = Console.ReadLine()
                    .ToLower()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                //queue to strore the input;
                var tempQueue = new Queue<string>(input);

                while (tempQueue.Count > 0)
                {
                    //var for current quantity;
                    var quantity = int.Parse(tempQueue.Dequeue());
                    //var for current material;
                    var material = tempQueue.Dequeue();

                    //fill the material dictioanary;
                    if (!mats.ContainsKey(material))
                    {
                        mats.Add(material, quantity);
                    }
                    else
                    {
                        mats[material] += quantity;
                    }

                    //check for winner;
                    if (mats.ContainsKey("fragments") && mats["fragments"] >= 250)
                    {
                        mats["fragments"] -= 250;
                        Console.WriteLine("Valanyr obtained!");
                        flag = true;
                        break;
                    }
                    else if (mats.ContainsKey("motes") && mats["motes"] >= 250)
                    {
                        mats["motes"] -= 250;
                        Console.WriteLine("Dragonwrath obtained!");
                        flag = true;
                        break;
                    }
                    else if (mats.ContainsKey("shards") && mats["shards"] >= 250)
                    {
                        mats["shards"] -= 250;
                        Console.WriteLine("Shadowmourne  obtained!");
                        flag = true;
                        break;
                    }
                }//end of second while loop;

                if (flag == true)
                {
                    break;
                }

            }//end of the first while loop;
           
            //printing the legendary material;
            foreach (var mat in mats
                .Where(x => x.Key == "fragments" || x.Key == "motes" || x.Key == "shards")
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{mat.Key}: {mat.Value}");
            }

            //printing the junk material;
            foreach (var mat in mats
                .Where(x => !(x.Key == "fragments" || x.Key == "motes" || x.Key == "shards"))
                .OrderBy(x => x.Key))
            {
                Console.WriteLine($"{mat.Key}: {mat.Value}");
            }
        }
    }
}
