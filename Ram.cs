using System;

namespace Custom_Colours
{
    public class Ram : Vehicle
    {  // Gas powered truck
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            Console.WriteLine("The Ram takes diesel");
        }
                public override void Drive() => Console.WriteLine("Grrrrrroooooom!");

    }
}