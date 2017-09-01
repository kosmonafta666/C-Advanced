namespace Zipping_Sliced_Files
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;
    using System.IO.Compression;

    public class ZippingSlicedFiles
    {
        //const for destination folder;
        const string DestinationDirectory = @"..\..\Sliced Files\";
        //const for source file;
        const string SourceFile = "../../source.avi";

        public static void Main(string[] args)
        {
            //read the parts;
            Console.Write("How many parts: ");
            var parts = int.Parse(Console.ReadLine());

            //slice file and compress to given parts;
            SliceAndCompreses(SourceFile, DestinationDirectory, parts);

            //create a list of sliced and compressed parts
            var slicedFiles = new List<string>();

            for (int i = 1; i <= parts; i++)
            {
                //string for current sliced part;
                var currentPart = String.Format("{0}Part-{1}.gz", DestinationDirectory, i);

                slicedFiles.Add(currentPart);
            }

            //assemble the file from given parts;
            Assemble(slicedFiles, DestinationDirectory);
        }

        //method for slice file and compress to given parts;
        private static void SliceAndCompreses(string sourceFile, string destinationDirectory, int parts)
        {
            using (var sourceStream = new FileStream(sourceFile, FileMode.Open))
            {
                //var for buffer size;
                var bufferSize = (sourceStream.Length / parts) + (sourceStream.Length % parts);
                //var for buffer to read;
                var buffer = new byte[bufferSize];

                for (int i = 1; i <= parts; i++)
                {
                    //string for current sliced part;
                    var currentPart = String.Format("{0}Part-{1}.gz", destinationDirectory, i);

                    using (var createStream = new FileStream(currentPart, FileMode.Create))
                    {
                        using (var compressStream = new GZipStream(createStream, CompressionMode.Compress, false))
                        {
                            var readBytes = sourceStream.Read(buffer, 0, buffer.Length);

                            compressStream.Write(buffer, 0, buffer.Length);
                        }                       
                    }
                }
            }
        }

        //method for asseble the file from given parts;
        private static void Assemble(List<string> slicedFiles, string destinationDirectory)
        {

            //string for name of the assembled file;
            string assembledName = String.Format("{0}assembled.avi", destinationDirectory);

            using (var resultFile = new FileStream(assembledName, FileMode.Create))
            {
                foreach (var file in slicedFiles)
                {
                    using (var sourceFile = new FileStream(file, FileMode.Open))
                    {
                        using (var decompressStream = new GZipStream(sourceFile, CompressionMode.Decompress, false))
                        {
                            //var for buffer size;
                            var bufferSize = sourceFile.Length;
                            //var for buffer to read;
                            var buffer = new byte[bufferSize];

                            decompressStream.Read(buffer, 0, buffer.Length);

                            resultFile.Write(buffer, 0, buffer.Length);
                        }                      
                    }
                }
            }
        }
    }

}
