using StrategyDesignPatterns.Strategies;

namespace StrategyDesignPatterns
{
    internal class Hero
    {
        private readonly string name;
        private IWeapon? weapon;

        public Hero(string name)
        {
            this.name = name;
        }

        public void SetWeapon(IWeapon weapon)
        {
            this.weapon = weapon;
        }

        public void Attack()
        {
            Console.WriteLine(">>>");

            if (weapon is null)
            {
                Console.WriteLine($"{name} can't attack. Set a weapon.");
                return;
            }

            Console.WriteLine($"{name} stands menacingly");
            Console.Write($"{name} ");

            weapon.Shoot();

            Console.WriteLine($"{name} ceases to stand menacingly");
        }
    }
}
