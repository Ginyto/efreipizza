﻿namespace Projet {

    class Program
    {
        static void Main(string[] args)
        {
            /** Payment UnPayment;
            UnPayment= new Payment("nom","prenom","typedepayemnt",52);
            Console.WriteLine(UnPayment.MakePayment());
           
            Pizza margarita = new Pizza("Margarita", 10, 10, "Tomato sauce, Mozzarella");
            Drink coca = new Drink("Coca-cola", 25, 3.99);
            Client jimmy = new Client("Jimmmy", "Potard", 015, "4 mars 2022");


            coca.PrintDrink();

            coca.Price = 2.55;

            coca.PrintDrink();

            Pizza pepperoni = new Pizza("Pepperoni", 10, 10, "Tomato sauce, Mozzarella, Pepperoni");

            margarita.PrintPizza();
            pepperoni.PrintPizza();
            
            jimmy.PrintClient();


            Console.WriteLine(coca.Price);
**/
            
            string Name = Console.ReadLine();

            string FirstName = Console.ReadLine();

            int OrderNumber = Convert.ToInt32(Console.ReadLine());

            string DateOfFirstCommand = Console.ReadLine();

            Client UnClient = new Client(Name,FirstName,OrderNumber,DateOfFirstCommand);
            UnClient.PrintClient();

        }
    }

}


            
            