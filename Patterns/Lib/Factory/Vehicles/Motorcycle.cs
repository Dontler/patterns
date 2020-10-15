using System;

namespace Patterns.Lib.Factory.Vehicles
{
    public class Motorcycle: Vehicle
    {
        public Motorcycle()
        {
            Name = "Motorcycle";
            MaxSpeed = 90;
            Type = VehicleType.Motorcycle;
        }
        
        public override void Drive()
        {
            Console.WriteLine($"Vehicle {Name} rides with max speed {MaxSpeed}");
        }
    }
}