namespace Week8;

public class CargoContainer<T> where T : DeliveryItem
{
    private List<T> _deliveryItems = new List<T>();
    public void AddItem(T device)
    {
        _deliveryItems.Add(device);
    }

    public double GetTotalCost() => _deliveryItems.Sum(t => t.CalculateCost());
}