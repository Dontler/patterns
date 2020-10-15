using System;
using Patterns.Lib.Factory.Vehicles;

namespace Patterns.Lib.Factory
{
    public class VehicleFactory
    {
        public Vehicle InstantiateVehicleByType(VehicleType type)
        {
            switch (type)
            {
                case VehicleType.Car:
                    return new Car();
                case VehicleType.Motorcycle:
                    return new Motorcycle();
                default:
                    throw new AggregateException("Not supported vehicle type!");
            }
        } 
    }
}