Pizza margarita = new Pizza("Margarita", 10, 10, "Tomato sauce, Mozzarella");
Drink coca = new Drink("Coca-cola", 25, 3.99);
Client jimmy = new Client("Jimmmy", "Potard", 015, "4 mars 2022");

coca.PrintDrink();

coca.Price = 2.55;

coca.PrintDrink();


jimmy.PrintClient();

Console.WriteLine(coca.Price);