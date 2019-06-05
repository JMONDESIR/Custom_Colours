using System;

namespace Custom_Colours
{

    public class Tesla : Vehicle
    {  // Electric car
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            Console.WriteLine("The Tesla charges and runs at 85 KWh");
        }
                public override void Drive() => Console.WriteLine("-no sound");

    }
}