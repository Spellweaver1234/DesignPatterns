namespace FactoryMethod.Domain
{
    internal class GymWithPoolMembership : IMembership
    {

        private readonly string _name;
        private readonly decimal _price;
        public GymWithPoolMembership(decimal price)
        {
            _name = "Gym with Pool membership";
            _price = price;
        }
        public string Name => _name;
        public string Description { get; set; }

        public decimal GetPrice() => _price;
    }
}
