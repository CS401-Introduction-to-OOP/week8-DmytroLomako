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

public class Parcel : DeliveryItem
{
    private string Dimensions { get; }

    public Parcel(string trackingNumber, double weight, string dimensions) : base(trackingNumber, weight)
    {
        Dimensions = dimensions;
    }

    public override double CalculateCost()
    {
        return 50 + Weight * 25;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Dimensions : {Dimensions}");
    }
}