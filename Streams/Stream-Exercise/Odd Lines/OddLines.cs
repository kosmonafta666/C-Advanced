namespace Odd_Lines
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class OddLines
    {
        public static void Main(string[] args)
        {
            using (var reader = new StreamReader("../../test.txt"))
            {
                //var for count lines;
                var countLines = 0;

                //var for current read lines;
                var readLine = "";

                while ((readLine = reader.ReadLine()) != null)
                {
                    if (countLines % 2 != 0)
                    {
                        Console.WriteLine(readLine);
                    }

                    countLines++;
                }
            }
        }
    }
}
