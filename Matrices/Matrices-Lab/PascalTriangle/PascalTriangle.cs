namespace PascalTriangle
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PascalTriangle
    {
        public static void Main(string[] args)
        {
            //read the heigth of piramyd;
            var heigth = int.Parse(Console.ReadLine());

            //var for pascal array;
            var pascal = new long[heigth][];

            //initializing the skeleton of jagged array;
            for (int row = 0; row < pascal.Length; row++)
            {
                pascal[row] = new long[row + 1];
                pascal[row][row] = 1;
                pascal[row][0] = 1;
            }
            
            //fill the jagged array;
            for (int row = 2; row < pascal.Length; row++)
            {
                for (int col = 1; col < row; col++)
                {
                    pascal[row][col] = pascal[row - 1][col] + pascal[row - 1][col - 1];
                } 
            }

            //printing the result;
            for (int i = 0; i < pascal.Length; i++)
            {
                Console.WriteLine(string.Join(" ", pascal[i]));
            }

        }
    }
}
