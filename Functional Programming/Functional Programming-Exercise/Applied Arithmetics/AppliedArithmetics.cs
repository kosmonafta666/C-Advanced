namespace Applied_Arithmetics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AppliedArithmetics
    {
        public static void Main(string[] args)
        {
            //read the numbers;
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            //action to add 1 for every number;
            Action<int[]> add = x => 
            {
                for (int i = 0; i < x.Length; i++)
                {
                    x[i] += 1;
                }
            };

            //action to substract 1 for every number;
            Action<int[]> subtract = x =>
            {
                for (int i = 0; i < x.Length; i++)
                {
                    x[i] -= 1;
                }
            };

            //action to multiply 2 for every number;
            Action<int[]> multyply = x =>
            {
                for (int i = 0; i < x.Length; i++)
                {
                    x[i] *= 2;
                }
            };

            //action to print numbers;
            Action<int[]> print = x => Console.WriteLine("{0}", string.Join(" ", x));

            //read the current command;
            var command = Console.ReadLine();

            while (command != "end")
            {
                switch (command)
                {
                    case "add":
                        add(numbers);
                        break;
                    case "subtract":
                        subtract(numbers);
                        break;
                    case "multiply":
                        multyply(numbers);
                        break;
                    case "print":
                        print(numbers);
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}
