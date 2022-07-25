using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Automobile> automobiles = new List<Automobile>()
        {
            new SportCar(1, 10, 5, 100),
            new PassengerVehicle(1, 10, 5, 100, 8, 4),
            new CargoVehicle(1, 10, 5, 100, 5000, 4000)
        };

            foreach (var automobile in automobiles)
            {
                automobile.DisplayCurrentFuelRange();
            }
            Console.ReadLine();
        }
    }
}
