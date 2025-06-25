using WithStrategy.Strategy;

namespace WithStrategy
{
    public class PassengerVehicle : Vehicle
    {
        public PassengerVehicle() : base(new NormalDriveStrategy())
        {
        }
    }
}