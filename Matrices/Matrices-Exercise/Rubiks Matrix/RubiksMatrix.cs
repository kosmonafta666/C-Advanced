namespace Rubiks_Matrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RubiksMatrix
    {
        public static void Main(string[] args)
        {
            //read the dimensions of matrix;
            var dimensions = Console.ReadLine()
                .Split(' ')
                .ToArray();

            //var for row;
            var row = int.Parse(dimensions[0]);
            //var for col;
            var col = int.Parse(dimensions[1]);

            //matrix for rubik;
            var rubik = new int[row][];
            //var for count;
            var count = 1;

            //fill the rubik;
            for (int rowIndex = 0; rowIndex < row; rowIndex++)
            {
                rubik[rowIndex] = new int[col];

                for (int colIndex = 0; colIndex < col; colIndex++)
                {
                    rubik[rowIndex][colIndex] = count;
                    count++;
                }
            }

            //read the number of commands
            var n = int.Parse(Console.ReadLine());

            //read the commands;
            for (int i = 0; i < n; i++)
            {
                //read the current command;
                var currentCommand = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                //var for row or col index;
                var rsIndex = int.Parse(currentCommand[0]);
                //var for direction;
                var direction = currentCommand[1];
                //var for moves number;
                var moves = int.Parse(currentCommand[2]);

                //check the move command;
                switch(direction)
                {
                    case "up":
                        MoveCol(rubik, rsIndex, moves);
                        break;
                    case "down":
                        MoveCol(rubik, rsIndex, rubik.Length - moves % rubik.Length);
                        break;
                    case "left":
                        MoveRow(rubik, rsIndex, moves);
                        break;
                    case "right":
                        MoveRow(rubik, rsIndex, rubik[0].Length - moves % rubik[0].Length);
                        break;
                }
            }

            /*for (int i = 0; i < rubik.Length; i++)
            {
                Console.WriteLine(string.Join(" ", rubik[i]));
            }*/

            //check if number are they places;
            var element = 1;

            for (int rowIndex = 0; rowIndex < rubik.Length; rowIndex++)
            {
                for (int colIndex = 0; colIndex < rubik[0].Length; colIndex++)
                {
                    if (rubik[rowIndex][colIndex] == element)
                    {
                        Console.WriteLine("No swap required");
                    }
                    else
                    {
                        for (int r = 0; r < rubik.Length; r++)
                        {
                            for (int c = 0; c < rubik[0].Length; c++)
                            {
                                if (rubik[r][c] == element)
                                {
                                    var currentElement = rubik[rowIndex][colIndex];

                                    rubik[rowIndex][colIndex] = element;

                                    rubik[r][c] = currentElement;

                                    Console.WriteLine($"Swap ({rowIndex}, {colIndex}) with ({r}, {c})");
                                }
                            }
                        }
                    }

                    element++;
                }
            }

        }

        //method to move and specific column with specific step;
        private static void MoveRow(int[][] rubik, int rsIndex, int moves)
        {
            //var for temp array for new row;
            var temp = new int[rubik[0].Length];

            //rearange the rubik;
            for (int colIndex = 0; colIndex < rubik[0].Length; colIndex++)
            {
                temp[colIndex] = rubik[rsIndex][(colIndex + moves) % rubik[0].Length];
            }

            rubik[rsIndex] = temp;
        }

        //method to move and specific column with specific step;
        private static void MoveCol(int[][] rubik, int rsIndex, int moves)
        {
            //var for temp array for new column;
            var temp = new int[rubik.Length];

            //rearange the rubik;
            for (int rowIndex = 0; rowIndex < rubik.Length; rowIndex++)
            {
                temp[rowIndex] = rubik[(rowIndex + moves) % rubik.Length][rsIndex];
            }

            for (int rowIndex = 0; rowIndex < rubik.Length; rowIndex++)
            {
                rubik[rowIndex][rsIndex] = temp[rowIndex];
            }
        }
       
    }
}
