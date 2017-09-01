namespace Action_Print
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class ActionPrint
    {
        public static void Main(string[] args)
        {
            //read the input string;
            var inputStr = Console.ReadLine()
                .Split(' ');

            //action for print string;
            Action<string> printer = x => Console.WriteLine(x);


            PrintAllStr(inputStr, printer);
        }

        //method to mprint all strings in array of strings;
        private static void PrintAllStr(string[] inputStr, Action<string> printer)
        {
            foreach (var str in inputStr)
            {
                printer(str);
            }    
        }
    }
}
