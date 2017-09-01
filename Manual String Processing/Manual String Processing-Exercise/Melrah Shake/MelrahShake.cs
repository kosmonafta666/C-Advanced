namespace Melrah_Shake
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MelrahShake
    {
        public static void Main(string[] args)
        {
            //read the inpit string;
            var inputStr = Console.ReadLine();
            //read the pattern;
            var pattern = Console.ReadLine();

            while (true)
            {
                //find first match;
                int firstIndex = inputStr.IndexOf(pattern);
                //find last match;
                int lastIndex = inputStr.LastIndexOf(pattern);

                if (firstIndex == -1 || firstIndex == lastIndex)
                {
                    break;
                }

                inputStr = inputStr.Remove(lastIndex, pattern.Length);
                inputStr = inputStr.Remove(firstIndex, pattern.Length);

                Console.WriteLine("Shaked it.");

                if (pattern.Length <= 1)
                    break;
         
                //remove it;
                pattern = pattern.Remove(pattern.Length / 2, 1);
            }

            //print the result;
            Console.WriteLine("No shake." + Environment.NewLine + inputStr);
        }
    }
}
