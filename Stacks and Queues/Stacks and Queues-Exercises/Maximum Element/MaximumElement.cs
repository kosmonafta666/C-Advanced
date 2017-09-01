namespace Maximum_Element
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MaximumElement
    {
        public static void Main(string[] args)
        {
            //read the number of queries;
            var queries = uint.Parse(Console.ReadLine());

            //stack for the result;
            var stackResult = new Stack<int>();

            //var for max element;
            var maxElement = int.MinValue;

            //stack for max elements;
            var maxElements = new Stack<int>();

            //execute the operations in queries;
            for (int i = 1; i <= queries; i++)
            {
                //read teh current command;
                var command = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                //check the command;
                if (command.Length == 2 && command[0] == 1)
                {
                    stackResult.Push(command[1]);

                    //asign the max element and added to max elements stack;
                    if (command[1] >= maxElement)
                    {
                        maxElement = command[1];
                        maxElements.Push(maxElement);
                    }
                }
                else if (command[0] == 2)
                {
                    //remove the last element from result stack;
                    int removeElement = stackResult.Pop();
                   
                    if (removeElement == maxElements.Peek())
                    {
                        //remove the last element from max elements stack;
                        maxElements.Pop();

                        //asign the max element;
                        if (maxElements.Count > 0)
                        {
                            maxElement = maxElements.Peek();
                        }
                        else
                        {
                            maxElement = int.MinValue;
                        }
                    }                    
                }
                else if (stackResult.Count() > 0 && command[0] == 3)
                {
                    Console.WriteLine(maxElements.Peek());
                }//end of checking the commands;
            }
        }
    }
}
