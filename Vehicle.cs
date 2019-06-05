using System;

namespace Custom_Colours
{

    public class Vehicle
    {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        public virtual void Drive() => Console.WriteLine("Vroom!");
    }
}