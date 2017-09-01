namespace Text_Filter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TextFilter
    {
        public static void Main(string[] args)
        {
            //read the banned words
            var bannedWords = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            //read the input strings;
            var inputString = Console.ReadLine();

            foreach (var bannedWord in bannedWords)
            {
                //var for word to be repalced;
                var replaceWord = new string('*', bannedWord.Length);

                if (inputString.Contains(bannedWord))
                {
                    inputString = inputString.Replace(bannedWord, replaceWord);
                }
            }

            //print the result;
            Console.WriteLine(inputString);
        }
    }
}
