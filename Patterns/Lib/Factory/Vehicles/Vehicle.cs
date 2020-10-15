namespace Patterns.Lib.Factory.Vehicles
{
    public abstract class Vehicle
    {
        protected string Name;
        protected int MaxSpeed;

        protected VehicleType Type;
        
        public abstract void Drive();
    }
}