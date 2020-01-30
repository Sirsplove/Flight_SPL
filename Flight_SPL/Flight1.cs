using System;

namespace Flight_SPL
{
    class Program
    {
        static void Main(string[] args)
        {
            City o = new City("Louisville, KY", 38.2527, 85.7585);
            City d = new City("Los Angeles, CA", 34.0522, 118.243680);

            Flight f = new Flight("TuxEdo AirLines", "A0619", o, d);
            Console.WriteLine(f.printFlightDetails());

            City o2 = new City("Louisville, KY", 38.2527, 85.7585);
            City d2 = new City("New York, NY", 40.7128, 74.0060);

            Flight f2 = new Flight("Zeus Air", "A0725", o2, d2);
            Console.WriteLine(f2.printFlightDetails());
        }
    }
}
