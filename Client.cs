class Client {

    public string Name { get; set; }
    public string FirstName { get; set; }
    public int OrderNumber { get; set; }
    public string DateOfFirstCommand { get; set; }

    public Client(string name, string firstname, int ordernumber, string dateoffirstcommand)
    {
        Name = name;
        FirstName = firstname;
        OrderNumber = ordernumber;
        DateOfFirstCommand = dateoffirstcommand;
    }

    public Client()
    {
        Console.WriteLine($"Création d'un nouveau client...");
        Console.WriteLine($"Nom du client ?");
        this.Name = Console.ReadLine();
        Console.WriteLine(Name);
    }

    public void PrintClient()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"FirstName: {FirstName}");
        Console.WriteLine($"OrderNumber: {OrderNumber}");
        Console.WriteLine($"DateOfFirstCommand: {DateOfFirstCommand}");
    }

    public void CreerClient()
    {
        Console.WriteLine($"Création d'un nouveau client...");
        Console.WriteLine($"Nom du client ?");
        string name = Console.ReadLine();
        Console.WriteLine(name);

    }




}

