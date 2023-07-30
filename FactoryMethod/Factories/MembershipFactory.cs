using FactoryMethod.Domain;

namespace FactoryMethod.Factories
{
    internal abstract class MembershipFactory
    {
        public abstract IMembership GetMembership();
    }
}
