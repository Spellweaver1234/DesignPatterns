namespace FactoryMethod.Domain
{
    internal interface IMembership
    {
        public string Name { get; }
        public string Description { get; set; }
        decimal GetPrice();
    }
}
