namespace Simple_Text_Editor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SimpleTextEditor
    {
        public static void Main(string[] args)
        {
            //var for number of operations;
            var operations = int.Parse(Console.ReadLine());

            //stack for strings in operations;
            var stackStrings = new Stack<string>();

            for (int i = 1; i <= operations; i++)
            {
                //var for current operation;
                var currentOperation = Console.ReadLine()
                    .Split(new[] { ' '}, StringSplitOptions.RemoveEmptyEntries);

                if (currentOperation.Length == 2 && int.Parse(currentOperation[0]) == 1)
                {
                    if (stackStrings.Count == 0)
                    {
                        //add first text to stack;
                        stackStrings.Push(currentOperation[1]);
                    }
                    else
                    {
                        //last text in stack;
                        var text = stackStrings.Peek();
                        //new text to push;
                        var newText = text + currentOperation[1];
                        //push it to stack
                        stackStrings.Push(newText);
                    }
                }
                else if (currentOperation.Length == 2 && int.Parse(currentOperation[0]) == 2)
                {
                    //last text in stack
                    var lastString = stackStrings.Peek();
                    //how many char to erase;
                    var eraseCount = int.Parse(currentOperation[1]);
                    //new  text with erased chars;
                    var newString = lastString.Substring(0, (lastString.Length - eraseCount));
                    //push it;
                    stackStrings.Push(newString);
                }
                else if (currentOperation.Length == 2 && int.Parse(currentOperation[0]) == 3)
                {
                    //index of printed char;
                    var indexOfChar = int.Parse(currentOperation[1]);
                    //last text in stack;
                    var currentString = stackStrings.Peek();
                    //char to print;
                    var charToPrint = currentString[indexOfChar - 1];
                    //print;
                    Console.WriteLine(charToPrint);
                }
                else if (int.Parse(currentOperation[0]) == 4)
                {
                    //erase last update of text;
                    stackStrings.Pop();
                }
            }
        }
    }
}
