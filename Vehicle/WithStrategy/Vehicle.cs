using WithStrategy.Strategy;

namespace WithStrategy
{
    public class Vehicle
    {
        IDriveStrategy _driveObject;

        public Vehicle(IDriveStrategy driveObject)
        {
            _driveObject = driveObject;
        }
        public void Drive()
        {
            _driveObject.Drive();
        }
    }
}