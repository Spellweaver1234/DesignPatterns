namespace Proxy;

internal class ChiefProxy : IChief
{
    private readonly Chief chief;
    private IDictionary<int, string>? statuses;

    // получение шефа для работы с ним
    public ChiefProxy(Chief chief)
    {
        this.chief = chief;
    }

    public IEnumerable<Order> GetOrders()
    {
        Console.WriteLine($"[{DateTime.Now:dd.MM.yyyy HH:mm:ss}] GetOrders()");
        return chief.GetOrders();
    }

    // проксирование статусов  
    public IDictionary<int, string> GetStatuses()
    {
        statuses ??= chief.GetStatuses();

        return statuses;
    }
}