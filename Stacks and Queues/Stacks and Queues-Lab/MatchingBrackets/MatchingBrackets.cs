namespace MatchingBrackets
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MatchingBrackets
    {
        public static void Main(string[] args)
        {
            //read the expession;
            var expression = Console.ReadLine();

            //stack for brackets;
            var brackets = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    brackets.Push(i);
                }

                if (expression[i] == ')')
                {
                    //var for start index for sub expession;
                    var startIndex = brackets.Pop();
                    //var for subexpresiion;
                    var subExpession = expression.Substring(startIndex, i - startIndex + 1);

                    //print the sub expression;
                    Console.WriteLine(subExpession);
                }
            }
        }
    }
}
