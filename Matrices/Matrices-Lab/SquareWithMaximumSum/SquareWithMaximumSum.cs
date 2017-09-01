namespace SquareWithMaximumSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SquareWithMaximumSum
    {
        public static void Main(string[] args)
        {
            //read the size of the matrix;
            var matrixSize = Console.ReadLine()
                .Split(new string[] { ", " },StringSplitOptions.RemoveEmptyEntries);

            //var for matrix;
            var matrix = new int[int.Parse(matrixSize[0]), int.Parse(matrixSize[1])];

            //read the input and fill the matrix;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                //read the current inpurt;
                var currentInput = Console.ReadLine()
                    .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentInput[col];
                }
            }


            //var for square best square matrix;
            var squareMatrix = new int[2, 2];
            //var for best sum;
            var bestSum = 0;

            //find best sum and fill the square matrix;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    //var for current sum of current square matrix;
                    int currentSum = matrix[row, col] + matrix[row, col + 1]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1];

                    //check for best sum and fill the square matrix;
                    if (currentSum > bestSum)
                    {
                        bestSum = currentSum;
                        squareMatrix[0, 0] = matrix[row, col];
                        squareMatrix[0, 1] = matrix[row, col + 1];
                        squareMatrix[1, 0] = matrix[row + 1, col];
                        squareMatrix[1, 1] = matrix[row + 1, col + 1];
                    }
                }
            }

            //print the square matrix and calcualte sum of elements;
            
            var totalSum = 0;
            for (int row = 0; row < squareMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < squareMatrix.GetLength(1); col++)
                {
                    totalSum += squareMatrix[row, col];
                    Console.Write("{0} ", squareMatrix[row, col]);
                }

                Console.WriteLine();
            }

            //print the total sum;
            Console.WriteLine(totalSum);
        }
    }
}
