namespace Magic_exchangeable_words
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MagicExchangeableWords
    {
        public static void Main(string[] args)
        {
            //read the input string;
            var input = Console.ReadLine().Split(' ').ToArray();

            //var for first word;
            var str1 = input[0];
            //var for second word;
            var str2 = input[1];

            //hash set for first word;
            HashSet<char> listStr1 = new HashSet<char>();
            //hash se t for second word;
            HashSet<char> listStr2 = new HashSet<char>();

            //fill the first hash set;
            foreach (var chars in str1)
            {
                listStr1.Add(chars);
            }

            //fill the second word;
            foreach (var chars in str2)
            {
                listStr2.Add(chars);
            }

            //print the result;
            if (listStr1.Count != listStr2.Count)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("true");
            }
        }
    }
}
