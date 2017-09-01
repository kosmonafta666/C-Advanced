namespace Add_VAT
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AddVAT
    {
        public static void Main(string[] args)
        {
            //func to add VAT to double price;
            Func<double, double> addVAT = n => Math.Round((n / 5) + n, 2);

            //read the input string, split, convert and add VAT;
            var inputStr = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(addVAT)
                .ToList();

            foreach (var price in inputStr)
            {
                Console.WriteLine("{0:F2}", price);
            }
        }
    }
}
