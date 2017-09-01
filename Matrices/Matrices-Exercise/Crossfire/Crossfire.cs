namespace Crossfire
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Crossfire
    {
        public static void Main(string[] args)
        {
            //read the dimension of matrix;
            var dimensions = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            //var for rows;
            var rows = dimensions[0];
            //var for cols;
            var cols = dimensions[1];

            //var for count to fill the matrix;
            var count = 1;
            //var for matrix;
            var matrix = new List<List<int>>();
            //fill the matrix;
            for (int rowIndex = 0; rowIndex < rows; rowIndex++)
            {
                matrix.Add(new List<int>());

                for (int colIndex = 0; colIndex < cols; colIndex++)
                {
                    matrix[rowIndex].Add(count);

                    count++;
                }
            }

            //read the target input;
            var input = Console.ReadLine();

            while (input != "Nuke it from orbit")
            {
                //var for splitted input;
                var token = input
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                //var for target X;
                var x = token[0];
                //var for taget y;
                var y = token[1];
                //var for radius;
                var radius = token[2];

                for (int rowIndex = y - radius; rowIndex < y + radius; rowIndex++)
                {                   
                    
                }

                input = Console.ReadLine();
            }//end of while loop;
        }
    }
}
