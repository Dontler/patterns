using System;
using Patterns.Lib.Factory.Vehicles;

namespace Patterns.Lib.Factory
{
    public class FactoryTest
    {
        public static void Test()
        {
            var rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                var vehicleType = rand.Next(0, 2) == (int) VehicleType.Car ? VehicleType.Car : VehicleType.Motorcycle;
                var vehicle = CreateRandomVehicle(vehicleType);
                vehicle.Drive();
            }
        }

        private static Vehicle CreateRandomVehicle(VehicleType type)
        {
            var factory = new VehicleFactory();
            return factory.InstantiateVehicleByType(type);
        }
    }
}