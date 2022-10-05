class Client {

    public string Name { get; set; }
    public string FirstName { get; set; }
    public int OrderNumber { get; set; }
    public DateOnly DateOfFirstCommand { get; set; }

    public Client(string name, string firstname, int ordernumber, DateOnly dateoffirstcommand)
    {
        Name = name;
        FirstName = firstname;
        OrderNumber = ordernumber;
        DateOfFirstCommand = dateoffirstcommand;
    }

    public void PrintClient()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"FirstName: {FirstName}");
        Console.WriteLine($"OrderNumber: {OrderNumber}");
        Console.WriteLine($"DateOfFirstCommand: {DateOfFirstCommand}");
    }



}