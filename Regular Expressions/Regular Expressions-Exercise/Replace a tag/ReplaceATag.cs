namespace Replace_a_tag
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Text.RegularExpressions;

    public class ReplaceATag
    {
        public static void Main(string[] args)
        {
            //read the input string;
            var inputStr = Console.ReadLine();

            while(inputStr != "end")
            {
                //var for regex;
                var regex = new Regex(@"<a (href=.+?)>(.+)<\/a>");

                var result = Regex.Replace(inputStr, regex.ToString(),
                    @"[URL $1]$2[/URL]");

                Console.WriteLine(result);

                inputStr = Console.ReadLine();
            }        
        }
    }
}
