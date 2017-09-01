namespace Balanced_Parenthesis
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BalancedParenthesis
    {
        public static void Main(string[] args)
        {
            //read the parentheses;
            var parentheses = Console.ReadLine();

            //stack for parentheses;
            var stackParenthes = new Stack<char>();

            for (int i = 0; i < parentheses.Length; i++)
            {
                //var for current char;
                var currentChar = parentheses[i];

                switch(currentChar)
                {
                    case '{':
                        stackParenthes.Push('{');
                        break;
                    case '(':
                        stackParenthes.Push('(');
                        break;
                    case '[':
                        stackParenthes.Push('[');
                        break;
                    case '}':
                        if (stackParenthes.Count > 0)
                        {
                            char currentSymbol = stackParenthes.Pop();
                            if (currentSymbol != '{')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                        }
                        else
                        {
                            Console.WriteLine("NO");
                            return;
                        }                        
                        break;
                    case ')':
                        if (stackParenthes.Count > 0)
                        {
                            char currentSymbol = stackParenthes.Pop();
                            if (currentSymbol != '(')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                        }
                        else
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                        break;
                    case ']':
                        if (stackParenthes.Count > 0)
                        {
                            char currentSymbol = stackParenthes.Pop();
                            if (currentSymbol != '[')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                        }
                        else
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                        break;
                }
            }

            if (stackParenthes.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }    
    }
}
