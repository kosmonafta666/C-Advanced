namespace Nature_s_Prophet
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class NatureProphet
    {
        public static void Main(string[] args)
        {
            //read the dimensions of the matrix;
            var dimensions = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            //matrix for the result;
            var matrix = new int[dimensions[0]][];

            //initializing the matrix with zero;
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new int[dimensions[1]];
            }

            //reading the commands;
            var commands = "";

            while((commands = Console.ReadLine()) != "Bloom Bloom Plow")
            {
                //var for splited comands;
                var token = commands
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                //var for current row;
                var currRow = token[0];
                //var for current col;
                var currCol = token[1];

                //bloom the current flower;
                for (int row = 0; row < dimensions[0]; row++)
                {
                    for (int col = 0; col < dimensions[1]; col++)
                    {
                        //bloom the cols;
                        if (col == currCol)
                        {
                            matrix[row][col]++;
                        }
                        
                        //bloom the rows;
                        if (row == currRow)
                        {
                            if (col != currCol)
                            {
                                matrix[row][col]++;
                            }

                        }
                    }
                }
            }

            //printing the matrix;
            for (int row = 0; row < matrix.Length; row++)
            {              
                Console.WriteLine("{0}", string.Join(" ", matrix[row]));
            }
        }
    }
}
