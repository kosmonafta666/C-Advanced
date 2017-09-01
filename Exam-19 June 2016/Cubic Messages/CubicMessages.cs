namespace Cubic_Messages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Text.RegularExpressions;


    public class CubicMessages
    {
        public static void Main(string[] args)
        {
            //string for pattern for the regex;
            string pattern = @"^(\d+)([A-Za-z]+)([^A-Za-z]*)$";

            //var for regex;
            var regex = new Regex(pattern);           

            //read the messages;
            var command = "";

            while((command = Console.ReadLine()) != "Over!")
            {
                //read message length;
                var messageLength = int.Parse(Console.ReadLine());

                //match for coomand input;
                var match = regex.Match(command);

                if (match.Success)
                {
                    //var for first group of match;
                    var prefix = match.Groups[1].Value;
                   
                    //var for message;
                    var message = match.Groups[2].Value;

                    //var for third group of match;
                    var ending = String.Empty;
                    
                    if (match.Groups[3].Value != "")
                    {
                        ending = match.Groups[3].Value;                       
                    }

                    //check for valid message;
                    if (message.Length != messageLength)
                    {
                        continue;
                    }

                    //string for all digit in command message;
                    var indexes = Regex.Replace(prefix + ending, @"\D*", String.Empty);

                    //string buider for the result;
                    var result = new StringBuilder();

                    //fill the result;
                    foreach (var index in indexes)
                    {

                        //var for parsed index;
                        var parsedIndex = int.Parse(index.ToString());

                        if (parsedIndex >= 0 && parsedIndex < message.Length)
                        {
                            result.Append(message[parsedIndex]);
                        }
                        else
                        {
                            result.Append(" ");
                        }
                    }

                    //print result;
                    Console.WriteLine("{0} == {1}", message, result.ToString());
                }
                
            }//end of while loop;
        }
    }
}
