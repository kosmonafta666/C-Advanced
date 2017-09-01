namespace Count_Substring_Occurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CountSubstringOccurrences
    {
        public static void Main(string[] args)
        {
            //read the input string;
            var inputStr = Console.ReadLine().ToLower();
            //read the substring to match;
            var subStr = Console.ReadLine().ToLower();

            //var for count occurrences;
            var count = 0;
            //var for start index to find occurence;
            var startIndex = 0;

            while (startIndex < inputStr.Length)
            {
                //var for index of occurence;
                var occurrenceIndex = inputStr.IndexOf(subStr, startIndex);

                if (occurrenceIndex >= 0)
                {
                    count++;
                    startIndex = occurrenceIndex;
                }

                startIndex++;         
            }

            Console.WriteLine(count);
        }
    }
}
