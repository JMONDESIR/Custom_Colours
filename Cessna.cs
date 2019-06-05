using System;

namespace Custom_Colours
{
    public class Cessna : Vehicle
    {  // Propellor light aircraft
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            Console.WriteLine("The Cessna is refueling");
        }

        public override void Drive() => Console.WriteLine("Zoooooom!");
    }
}
