namespace Week8;

public abstract class DeliveryItem
{
    public string TrackingNumber { get; }
    public double Weight { get; } 
    
    public DeliveryItem(string trackingNumber,  double weight)
    {
        TrackingNumber = trackingNumber;
        Weight = weight;
    }
    
    public abstract double CalculateCost();
    public virtual void PrintInfo()
    {
        Console.WriteLine($"TrackingNumber : {TrackingNumber} | Weight : {Weight}");
    }
}

public class Letter : DeliveryItem
{
    public Letter (string trackingNumber,  double weight) : base (trackingNumber, weight){}

    public override double CalculateCost()
    {
        return 15 + Weight * 10;
    }
}