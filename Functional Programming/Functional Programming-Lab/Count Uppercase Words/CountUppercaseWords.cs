namespace Count_Uppercase_Words
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CountUppercaseWords
    {
        public static void Main(string[] args)
        {
            //func to check if first letter is upper;
            Func<string, bool> IsUpper = n => Char.IsUpper(n[0]);

            //read the input string;
            var inputStr = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            //list for the result;
            var result = inputStr
                .Where(IsUpper)
                .ToList();

            Console.WriteLine("{0}", string.Join("\r\n", result));
        }
    }
}
