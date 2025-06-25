namespace WithStrategy.Strategy
{
    public class SpecialDriveStrategy : IDriveStrategy
    {
        public void Drive()
        {
            Console.WriteLine("special driving capability");
        }
    }
}