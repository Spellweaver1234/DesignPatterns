using FactoryMethod.Domain;
using FactoryMethod.Factories;

class Program
{
    private static void Main()
    {


        Console.WriteLine(">>> Welcome to FitnessClub CRM <<<\n");
        Console.WriteLine("> Enter the membership type: ");

        Console.WriteLine("G - Gym");
        Console.WriteLine("P - Gym + Pool");
        Console.WriteLine("T - Personal training");

        string membershipType = Console.ReadLine();

        MembershipFactory factory = GetFactory(membershipType);

        IMembership membership = factory.GetMembership();

        Console.WriteLine("\n> Membership you've just created: \n");

        Console.WriteLine(
            $"\tName:\t\t{membership.Name}\n" +
            $"\tDescription:\t{membership.Description}\n" +
            $"\tPrice:\t\t{membership.GetPrice()}");

        Console.ReadLine();
    }

    private static MembershipFactory GetFactory(string membershipType)
    {
        return membershipType.ToLower() switch
        {
            "g" => new GymMembershipFactory(100, "Basic membership"),
            "p" => new GymWithPoolMembershipFactory(250, "Good price membership"),
            "t" => new PersonalTrainingMembershipFactory(400, "Best for professional"),
            _ => null
        };
    }
}


// Фабричный метод - порождающий шаблон проектирования. Удобное создание объектов. 