namespace SumOfAllElementsOfMatrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SumOfAllElementsOfMatrix
    {
        public static void Main(string[] args)
        {
            //read the size of matrix;
            var sizeOfMatrx = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            //var for matrix;
            var matrix = new int[int.Parse(sizeOfMatrx[0]), int.Parse(sizeOfMatrx[1])];

            //read the current input and fill the matrix;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                //read the current row;
                var currentRow = Console.ReadLine()
                    .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = currentRow[j];
                }
            }

            //var for total sum of elements of matrix;
            var totalSum = 0;

            //calculate the sum of all elements of matrix;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    totalSum += matrix[i, j];
                }
            }


            //printing the result;
            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(totalSum);
        }
    }
}
