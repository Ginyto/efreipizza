public class Deliver {
    
    public int DeliverNumber { get; set; }

    public Deliver(int delivernumber){
        DeliverNumber = delivernumber;
    }

    public void PrintDeliver()
    {
        Console.WriteLine($"DeliverNumber: {DeliverNumber}");
    }
}