using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_of_Palindromes
{
    public class MatrixOfPalindromes
    {
        public static void Main(string[] args)
        {
            //read the sixe of matrix;
            var matrixSize = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            //matrx for result;
            var result = new string[matrixSize[0], matrixSize[1]];

            //char array to build current string;
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            //fill the matrix;
            for (int row = 0; row < result.GetLength(0); row++)
            {
                for (int col = 0; col < result.GetLength(1); col++)
                {
                    //var for first and last letter;
                    char firstLetter = alphabet[row];
                    //var for second letter;
                    char secondLetter = alphabet[row + col];
                    //var for current palindrome;
                    string currentPalindrome = firstLetter.ToString() + secondLetter.ToString() + firstLetter.ToString();

                    //add current palindrome to matrix;
                    result[row,col] = currentPalindrome;
                }
            }

            //printing the result;
            for (int row = 0; row < result.GetLength(0); row++)
            {
                for (int col = 0; col < result.GetLength(1); col++)
                {
                    Console.Write("{0} ", result[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
