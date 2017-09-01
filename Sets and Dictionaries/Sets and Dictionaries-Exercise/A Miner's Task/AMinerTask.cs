namespace A_Miner_s_Task
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AMinerTask
    {
        public static void Main(string[] args)
        {
            //dictionary for minners;
            var minners = new Dictionary<string, int>();

            //var for count of input;
            var count = 1;

            //read the input;
            var input = Console.ReadLine();

            //var for current name;
            var name = "";

            while (input != "stop")
            {
                //check for name or quantity;
                if (count % 2 != 0)
                {
                    if (!minners.ContainsKey(input))
                    {
                        minners.Add(input, 0);                      
                    }

                    //assign the name;
                    name = input;
                }
                else if (count % 2 == 0)
                {
                    minners[name] += int.Parse(input);
                }

                count++;

                input = Console.ReadLine();
            }//end of while loop;

            //print the result;
            foreach (var item in minners)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
