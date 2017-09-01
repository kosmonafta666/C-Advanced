namespace Upper_Strings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class UpperStrings
    {
        public static void Main(string[] args)
        {
            //read the input and convert to string array;
            var input = Console.ReadLine()
                .Split(' ')
                .ToList();

            input.Select(x => x.ToUpper())
                .ToList()
                .ForEach(x => Console.Write("{0} ", x));
        }
    }
}
