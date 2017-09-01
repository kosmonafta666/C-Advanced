namespace Full_Directory_Traversal
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;

    public class FullDirectoryTraversal
    {
        //const for directory to full traverse;
        const string Dir = "../../";

        public static void Main(string[] args)
        {
            //create instance of IO class to get all info for Dir;
            var directory = new DirectoryInfo(Dir);
            //list to store all directories and files;
            var traverseList = new List<string>();

            //extract all info and strore to traverse list;
            TraverseDirectory(directory, traverseList);

            //string for desktop path to place report file;
            string reportPath = String
                .Format(@"{0}\report.txt", Environment.GetFolderPath(Environment.SpecialFolder.Desktop));

            //create and report file to desktop;
            using (var createStream = new StreamWriter(reportPath))
            {
                foreach (var item in traverseList)
                {
                    createStream.WriteLine(item);
                }
            }
        }


        //method to extract all direcrories and files form given directoey and store it;
        public static void TraverseDirectory (DirectoryInfo currentDir , List<string> result, string prefix = "")
        {
            foreach (var dir in currentDir.GetDirectories())
            {
                result.Add(prefix + dir.Name);
                TraverseDirectory(dir, result, prefix + "--");
            }

            foreach (var file in currentDir.GetFiles())
            {
                result.Add(prefix + file.Name);
            }           
        }
    }
}
