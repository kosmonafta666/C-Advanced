namespace Cubic_s_Rube
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CubicRube
    {
        public static void Main(string[] args)
        {
            //read the dimensions;
            var dimensions = int.Parse(Console.ReadLine());

            //jagged array for result;
            var matrix = new int?[dimensions][][];

            //initializing the matrix;
            for (int i = 0; i < dimensions; i++)
            {
                matrix[i] = new int?[dimensions][];

                for (int j = 0; j < dimensions; j++)
                {
                    matrix[i][j] = new int?[dimensions];
                }              
            }

            //var for particles count;
            var particlesCount = 0L;

            //var for bombarded count;
            var bombardedCount = 0;

            //read the commands;
            var commands = Console.ReadLine();

            while (commands != "Analyze")
            {
                //var for splitted commands;
                var token = commands.Split(' ')
                    .Select(int.Parse)
                    .ToList();

                //var for first point;
                var x = token[0];

                //var for second point;
                var y = token[1];

                //var for third point;
                var z = token[2];

                //var for particles;
                var particles = token[3];

                //check for valid bombard and change cell value;
                if ((x >= 0 && x < dimensions) && (y >= 0 && y < dimensions) && (z >= 0 && z < dimensions) && matrix[x][y][z] == null)
                {
                    matrix[x][y][z] = particles;

                    if (token[3] != 0)
                    {
                        particlesCount += particles;

                        bombardedCount++;
                    }                               
                }

                commands = Console.ReadLine();

            }//end of while loop;

            //var for cell count;
            var cellsCount = Math.Pow(dimensions, 3);

            //print the result;
            Console.WriteLine(particlesCount);

            Console.WriteLine(cellsCount - bombardedCount);

        }
    }
}
