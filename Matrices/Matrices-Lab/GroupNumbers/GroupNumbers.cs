namespace GroupNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GroupNumbers
    {
        public static void Main(string[] args)
        {
            //read the input and splitted;
            var input = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            //var for matrix array;
            var result = new int[3][];

            //var for temp list for current remainders;
            var remainders = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                //check for remainders and add to temp list;
                for (int j = 0; j < input.Length; j++)
                {
                    if (Math.Abs(input[j] % 3) == i)
                    {
                        remainders.Add(input[j]);
                    }
                }

                //asign the length of the current row;
                result[i] = new int[remainders.Count];
                
                //fill the current row;
                for (int h = 0; h < remainders.Count; h++)
                {
                    result[i][h] = remainders[h];
                }

                //clear the temp list;
                remainders.Clear();
            }

            //printing the result;
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(string.Join(" ", result[i]));
            }
        }
    }
}
