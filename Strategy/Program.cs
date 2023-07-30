
using StrategyDesignPatterns;
using StrategyDesignPatterns.Strategies;


// пытаемся атаковать без оружия
Hero hero = new Hero("Squidward");
hero.Attack();

// атакуем с оружием 1 
hero.SetWeapon(new Broom());
hero.Attack();

// атакуем с оружием 2
hero.SetWeapon(new Plunger());
hero.Attack();

Console.ReadKey();


// Стратегия - поведенческий шаблон который реализует принцип O (ocp - open close principle)
// открытость для расширения и невозможность модификации класса благодаря использованию интерфейса