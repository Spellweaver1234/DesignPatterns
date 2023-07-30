namespace StrategyDesignPatterns.Strategies
{
    internal class Plunger : IWeapon
    {
        public void Shoot()
        {
            Console.WriteLine("attacks with a plunger");
        }
    }
}
