public interface IShippable
{
    decimal ShipCost { get; }
    string Product { get; }
}

public class Bicycle : IShippable
{
    public decimal ShipCost => 9.50M;
    public string Product => "Bicycle";
}


public class LawnMower : IShippable
{
    public decimal ShipCost => 24.00M;
    public string Product => "Lawn Mower";
}



public class Shipper
{
    private List<IShippable> items = new List<IShippable>();

    public void Add(IShippable item)
    {
        if (items.Count < 10)
        {
            items.Add(item);
            Console.WriteLine($"{item.Product} has been added.");
        }
        else
        {
            Console.WriteLine("Maximum items reached. Cannot add more.");
        }
    }

}
