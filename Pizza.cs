class Pizza
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Size { get; set; }
    public string Description { get; set; }

    public Pizza(string name, double price, int size, string description)
    {
        Name = name;
        Price = price;
        Size = size;
        Description = description;
    }


    public void PrintPizza()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Price: {Price}");
        Console.WriteLine($"Price: {Size}");
        Console.WriteLine($"Description: {Description}");
    }

}

