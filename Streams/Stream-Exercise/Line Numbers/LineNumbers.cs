namespace Line_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LineNumbers
    {
        public static void Main(string[] args)
        {
            //ask from user to choose file path;
            Console.Write("Choose file path: ");

            var filePath = Console.ReadLine();

            using (var reader = new StreamReader(filePath))
            {
                //var for current line;
                var readLine = "";
                using (var writer = new StreamWriter("../../result.txt"))
                {
                    //count for new line;
                    int count = 1;

                    while ((readLine = reader.ReadLine()) != null)
                    {
                        writer.WriteLine($"{count}. {readLine}");

                        count++;
                    }
                }              
            }
        }
    }
}
