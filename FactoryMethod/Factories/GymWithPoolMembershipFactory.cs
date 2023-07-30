using FactoryMethod.Domain;

namespace FactoryMethod.Factories
{
    internal class GymWithPoolMembershipFactory : MembershipFactory
    {
        private readonly decimal _price;
        private readonly string _description;

        public GymWithPoolMembershipFactory(decimal price, string description)
        {
            _price = price;
            _description = description;
        }
        public override IMembership GetMembership()
        {
            GymWithPoolMembership membership = new(_price)
            {
                Description = _description
            };

            return membership;
        }
    }
}
