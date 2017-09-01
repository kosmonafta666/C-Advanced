namespace Fix_Emails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FixEmails
    {
        public static void Main(string[] args)
        {
            //dictionary for emails list;
            var emailList = new Dictionary<string, string>();

            //read the input;
            var input = Console.ReadLine();

            while (input != "stop")
            {
                //var for email;
                var email = Console.ReadLine();

                //fill the dictionary;
                if (!emailList.ContainsKey(input))
                {
                    if (!email.EndsWith("us") && !email.EndsWith("uk"))
                    {
                        emailList.Add(input, email);
                    }
                }
                else
                {
                    if (!email.EndsWith("us") && !email.EndsWith("uk"))
                    {
                        emailList[input] = email;
                    }
                }

                input = Console.ReadLine();
            }//end of while loop;

            //printing the result;
            foreach (var item in emailList)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
