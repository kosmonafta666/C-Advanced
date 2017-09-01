namespace Parse_Tags
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ParseTags
    {
        public static void Main(string[] args)
        {
            //read the input text;
            var input = Console.ReadLine();

            //var for open tag;
            var openTag = "<upcase>";
            //var for closed tag;
            var closedTag = "</upcase>";

            //var for start index;
            var startIndex = input.IndexOf(openTag);

            while(startIndex != -1)
            {
                //var for end index;
                var endIndex = input.IndexOf(closedTag);

                if (endIndex == -1)
                {
                    break;
                }

                //string to UpperCase;
                var toBeReplace = input.Substring(startIndex, endIndex + closedTag.Length - startIndex);

                var replace = toBeReplace
                    .Replace(openTag, String.Empty)
                    .Replace(closedTag, String.Empty)
                    .ToUpper();

                //replace with repalce string;
                input = input.Replace(toBeReplace, replace);

                startIndex = input.IndexOf(openTag);
            }

            //printing the result;
            Console.WriteLine(input);
        }
    }
}
