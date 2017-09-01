namespace Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Palindromes
    {
        public static void Main(string[] args)
        {
            //read the input string and spit it;
            var inputStr = Console.ReadLine()
                .Split(new[] { ' ', ',', '!', '?', '.' }, StringSplitOptions.RemoveEmptyEntries);


            //hash set for palindromes;
            var palindromes = new HashSet<string>();


            foreach (var word in inputStr)
            {
                if (IsPalindrome(word))
                {
                    palindromes.Add(word);
                }
            }

            //print the result;
            Console.WriteLine("[{0}]", string.Join(", ", palindromes.OrderBy(x => x)));

        }

        //method to check any word is palindrome;
        public static bool IsPalindrome(string word)
        {
            //bool for flag t return;
            bool flag = true;

            //var for left index;
            var leftIndex = 0;
            //var for right index;
            var rightIndex = word.Length - 1;

            //check the word;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[leftIndex] != word[rightIndex])
                {
                    flag = false;
                    break;
                }

                leftIndex++;
                rightIndex--;
            }

            return flag;
        }
    }
}
