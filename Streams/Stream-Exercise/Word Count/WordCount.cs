namespace Word_Count
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class WordCount
    {
        public static void Main(string[] args)
        {
            //dictionary for result stream;
            var resultWords = new Dictionary<string, int>();

            using (var wordsReader = new StreamReader("../../words.txt"))
            {
                //var for current read words;
                var currentWord = "";
                while ((currentWord = wordsReader.ReadLine()) != null)
                {
                    using (var textReader = new StreamReader("../../text.txt"))
                    {
                        string[] text = textReader.ReadToEnd()
                            .Split(new[] { ' ', '.', '?', '!', '-', ','}, StringSplitOptions.RemoveEmptyEntries);

                        currentWord = currentWord.ToLower();

                        foreach (var word in text)
                        {
                           
                            if (word.ToLower() == currentWord)
                            {
                                //fill the dictionary
                                if (!resultWords.ContainsKey(currentWord))
                                {
                                    resultWords.Add(currentWord, 1);
                                }
                                else
                                {
                                    resultWords[currentWord]++;
                                }
                            }
                        }
                    }//end of second using block;
                }//end of while loop;
            }//end of first using block;

            //writing the result;
            using (var writer = new StreamWriter("../../result.txt"))
            {
                //string for current line;
                var currentLine = string.Join("", resultWords.Select(x => x.Key + " - " + x.Value + "\r\n"));

                writer.WriteLine(currentLine);
            }
        }
    }
}
