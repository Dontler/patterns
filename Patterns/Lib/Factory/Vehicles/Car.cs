using System;

namespace Patterns.Lib.Factory.Vehicles
{
    public class Car: Vehicle
    {
        public Car()
        {
            Name = "Car";
            MaxSpeed = 180;
            Type = VehicleType.Car;
        }
        
        public override void Drive()
        {
            Console.WriteLine($"Vehicle {Name} rides with max speed {MaxSpeed}");
        }
    }
}