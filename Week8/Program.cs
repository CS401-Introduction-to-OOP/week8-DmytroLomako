namespace Week8;


class Program
{
    static void Main(string[] args)
    {
        var letter1 = new Letter("001", 2.47);
        var letter2 = new Letter("002", 1.85);
        var parcel1 = new Parcel("005", 3.11, "30x20x15");
        var parcel2 = new Parcel("006", 1.92, "10x5x8");
        
        letter1.PrintInfo();
        parcel1.PrintInfo();
        
        CargoContainer<DeliveryItem> myCargo = new CargoContainer<DeliveryItem>();
        
        myCargo.AddItem(letter1); myCargo.AddItem(letter2); myCargo.AddItem(parcel1); myCargo.AddItem(parcel2);

        var totalCost = myCargo.GetTotalCost();
        Console.WriteLine($"\nTotal cost: {totalCost}грн");
    }
}