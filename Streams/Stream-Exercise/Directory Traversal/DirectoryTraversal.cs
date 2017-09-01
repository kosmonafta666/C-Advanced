namespace Directory_Traversal
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;

    public class DirectoryTraversal
    {
        //const for directory to traverse;
        const string Dir = "../../";

        public static void Main(string[] args)
        {
            //var to extract infomation for Dir;
            var directory = new DirectoryInfo(Dir);
            //list for all files in directory;
            var files = directory.GetFiles();

            //dictionary for result;
            var resultDict = new Dictionary<string, Dictionary<string, double>>();

            //fill the dictionary;
            foreach (var file in files)
            {
                //var for key;
                var key = file.Extension;
                //var for value key;
                var name = file.Name;
                //var for size;
                var size = file.Length / 1024 + 1;

                if (!resultDict.ContainsKey(key))
                {
                    resultDict.Add(key, new Dictionary<string, double>());
                    resultDict[key][name] = size;
                }
                else
                {
                    if (!resultDict[key].ContainsKey(name))
                    {
                        resultDict[key].Add(name, size);
                    }
                    else
                    {
                        resultDict[key][name] = size;
                    }
                }

            }

            //string for desktop path to place report file;
            string reportPath = String
                .Format(@"{0}\report.txt", Environment.GetFolderPath(Environment.SpecialFolder.Desktop));

            //writing the report.txt;
            using (var createStream = new StreamWriter(reportPath))
            {
                foreach (var item in resultDict
                    .OrderByDescending(x => x.Value.Count()))
                {
                    createStream.WriteLine(item.Key);

                    foreach (var file in item.Value)
                    {
                        createStream.WriteLine($"--{file.Key} - {file.Value}kb");
                    }
                }
            }        
        }
    }
}
