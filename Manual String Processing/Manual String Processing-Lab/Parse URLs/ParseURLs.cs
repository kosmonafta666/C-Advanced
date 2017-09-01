namespace Parse_URLs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ParseURLs
    {
        public static void Main(string[] args)
        {
            //read the  input;
            var url = Console.ReadLine();

            //string for separator;
            var separator = "://";

            var urlTokens = url
                .Split(new[] { separator }, StringSplitOptions.RemoveEmptyEntries);

            //check for valid url;
            if (urlTokens.Length != 2 || urlTokens[1].IndexOf('/') == -1)
            {
                Console.WriteLine("Invalid URL");
            }
            else
            {
                //var for protocol;
                var protocol = urlTokens[0];
                //var for server;
                var server = urlTokens[1].Substring(0, urlTokens[1].IndexOf('/'));
                //var for resources;
                var resources = urlTokens[1].Substring(urlTokens[1].IndexOf('/') + 1);

                //printing the result;
                Console.WriteLine("Protocol = {0}", protocol);
                Console.WriteLine("Server = {0}", server);
                Console.WriteLine("Resources = {0}", resources);
            }            
        }
    }
}
