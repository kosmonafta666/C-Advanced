namespace Special_Words
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SpecialWords
    {
        public static void Main(string[] args)
        {
            //dictionary for result words;
            var result = new Dictionary<string, int>();

            //read the special words;
            var specialWords = Console.ReadLine()
                .Split(new[] { '(', ')', '[', ']', '<', '>', ',', '-', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //read the input string;
            var inputStr = Console.ReadLine()
                .Split(new[] { '(', ')', '[', ']', '<', '>', ',', '-', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //check for special words and fill the result dictionary;
            foreach (var special in specialWords)
            {
                result.Add(special, 0);

                foreach (var word in inputStr)
                {
                    if (special == word)
                    {
                        result[special]++;                      
                    }
                }
            }

            //printing the result;
            foreach (var item in result)
            {
                Console.WriteLine("{0} - {1}", item.Key, item.Value);
            }                 
        }
    }
}
