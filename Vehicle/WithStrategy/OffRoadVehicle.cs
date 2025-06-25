using WithStrategy.Strategy;

namespace WithStrategy
{
    public class OffRoadVehicle : Vehicle
    {
        public OffRoadVehicle() : base(new SpecialDriveStrategy())
        {
        }
    }
}