class Pizza
{
    public string Name { get; set; }
    public double Price { get; set; }
    public string Description { get; set; }

    public Pizza(string name, double price, string description)
    {
        Name = name;
        Price = price;
        Description = description;
    }


    public void PrintPizza()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Price: {Price}");
        Console.WriteLine($"Description: {Description}");
    }

}
