class Drink
{
    public string Name { get; set; }
    public int Volume { get; set; }
    public double Price { get; set; }

    public Drink(string name, int volume, double price)
    {
        Name = name;
        Volume = volume;
        Price = price;       
    }


    public void PrintDrink()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Volume: {Volume}");
        Console.WriteLine($"Price: {Price}");   
    }

}