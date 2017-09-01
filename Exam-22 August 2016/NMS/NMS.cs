namespace NMS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class NMS
    {
        public static void Main(string[] args)
        {
            //string buider for all word;
            var allWords = new StringBuilder();

            //string bulder for the result;
            var result = new StringBuilder();

            //read the input string and add it to all word string bulder;
            var inputStr = "";

            while ((inputStr = Console.ReadLine()) != "---NMS SEND---")
            {
                allWords.Append(inputStr);
            }

            //read the delimeter;
            var delimeter = Console.ReadLine();

            //read the all words builder and fill the result;
            for (int i = 0; i < allWords.Length - 1; i++)
            {
                result.Append(allWords[i]);

                //check to add the delimeter to result;;
                if (Char.Parse(allWords[i].ToString().ToLower()) > Char.Parse(allWords[i + 1].ToString().ToLower()))
                {
                    result.Append(delimeter);
                }               
            }

            //add the last char of all words;
            result.Append(allWords[allWords.Length - 1]);

            //print the result;
            Console.WriteLine("{0}", result);
        }
    }
}
