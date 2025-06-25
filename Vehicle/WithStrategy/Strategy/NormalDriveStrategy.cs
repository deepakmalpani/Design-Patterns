namespace WithStrategy.Strategy
{
    public class NormalDriveStrategy : IDriveStrategy
    {
        public void Drive()
        {
            Console.WriteLine("normal driving capability");
        }
    }
}