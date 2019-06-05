using System;

namespace Custom_Colours
{
    public class Zero : Vehicle
    {  // Electric motorcycle
        public double BatteryKWh { get; set; }

        public void ChargeBattery() {
            Console.WriteLine($"The Zero is charged to {this.BatteryKWh} KWh");
        }
    }
}