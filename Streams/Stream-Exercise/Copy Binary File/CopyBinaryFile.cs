namespace Copy_Binary_File
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CopyBinaryFile
    {
        //const for source binary file;
        const string SourceFile = "../../source.jpg";
        //const for result binary file;
        const string ResultFile = "../../result.jpg";

        public static void Main(string[] args)
        {
            using(var sourceStream = new FileStream(SourceFile, FileMode.Open))
            {
                using (var resultStream = new FileStream(ResultFile, FileMode.Create))
                {
                    var buffer = new byte[4096];

                    while(true)
                    {
                        var readFile = sourceStream.Read(buffer, 0, buffer.Length);

                        if (readFile == 0)
                        {
                            break;
                        }

                        resultStream.Write(buffer, 0, buffer.Length);
                    }
                }
            }
        }
    }
}
