namespace Extract_Email
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class ExtractEmail
    {
        public static void Main(string[] args)
        {
            //read the input;
            var input = Console.ReadLine();

            string pattern =
                "^|\\s[a-z0-9][\\._\\-a-z0-9]*[a-z0-9]@[a-z0-9][\\.\\-a-z0-9]*[a-z0-9]\\.[a-z]{2,}";

            Regex regex = new Regex(pattern);

            var matches = regex.Matches(input);

            //find matches and print it;
            foreach (Match match in matches)
            {
                string matchString = match.ToString();

                Console.WriteLine(matchString.Trim());
                
            }
        }
    }
}
