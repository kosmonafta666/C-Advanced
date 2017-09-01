namespace ParkingLot
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main(string[] args)
        {
            //read the input commands;
            var input = Console.ReadLine();

            //hash set for parking cars;
            var parkingCars = new HashSet<string>();

            while(input != "END")
            {
                //var for splitted input;
                var token = Regex.Split(input, ", ");

                //var for first command;
                var command = token[0];
                //var for car number;
                var carNumber = token[1];

                //check for command;
                if (command == "IN")
                {
                    parkingCars.Add(carNumber);
                }
                else if (command == "OUT")
                {
                    if (parkingCars.Contains(carNumber))
                    {
                        parkingCars.Remove(carNumber);
                    }                   
                }

                input = Console.ReadLine();
            }//end of while loop;

            //print the result;
            if (parkingCars.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var car in parkingCars.OrderBy(x => x))
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}
