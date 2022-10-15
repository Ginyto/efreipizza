using System;
using System.Collections;


    public class Command
    {
        public int Id { get; set; }
        public string Time { get; set; } = DateTime.Now.ToString("HH:mm:ss");
        public string Date { get; set; } = DateTime.Now.ToString("dd/MM/yyyy");
        public Commis Commis { get; set; }
        public Client Client { get; set; }
        public Deliver Deliver { get; set; }
        public ArrayList Pizzas = new ArrayList();
        public ArrayList Drinks = new ArrayList();
        public double Price { get; set; } = 0.00;
        public string State { get; set; } = "🤌🏽"; //state 0 = prise en charge commande , 1 = préparation commande , 2 = en livraison , 3 = livrée


        public Command()
        {

        }

        public Command(int id, Client client, Commis commis, Deliver deliver)
        {
            Id = id;

            Commis = commis;
            Client = client;
            Deliver = deliver;

        }

        public void PrintCommand()
        {    
            Console.WriteLine($"Command number : {Id}");

            Console.WriteLine($"------------------------------------------");
            Console.WriteLine($"Time : {Time}");
            Console.WriteLine($"Date : {Date}");
            Console.WriteLine($"Commis : {Commis.Name} {Commis.FirstName}");
            Console.WriteLine($"Client : {Client.Name} {Client.FirstName}");

            Console.WriteLine($"------------------------------------------");

            Console.WriteLine($"Pizzas :");

            foreach(Pizza p in Pizzas)
                Console.WriteLine($"- Pizza : {p.Name}, Price : {p.Price}$, Size : {p.Size}"); 

            Console.WriteLine($"------------------------------------------");

            Console.WriteLine($"Drinks :");

            foreach(Drink d in Drinks)
                Console.WriteLine($"- Drink : {d.Name}, Price : {d.Price}$, Size : {d.Size}");

            Console.WriteLine($"------------------------------------------");

            Console.WriteLine($"PriceOrder : {Price}$");   
        }

    }
    
    // public class Program
    // {

    //     public static void Main(string[] args)
    //     {

    //         /**

    //         ArrayList Pizzas = new ArrayList() {"hawaienne", "reine"};
    //         ArrayList Drinks = new ArrayList() {"coca", "sprite"};


    //         ArrayList Pizzasss = new ArrayList() {"hawaienne", "reine"};
    //         ArrayList Drinksss = new ArrayList() {"coca", "sprite"};


    //         Command command = new Command(12, "19h03", "22/08", "Steve", "Phillipe", "Olivier", Pizzas, Drinks, 27, 0);
    //         Command command2 = new Command(13, "19h07", "22/08", "Anim", "Orima", "Karim", Pizzasss, Drinksss, 21, 2);

    //         command.PrintCommand();
    //         command2.PrintCommand();

    //         Tib.addPizzas
    //         Tib.addDrinks


            

            
    //         Tib.Pizzas.Add("Pizzi");
    //         Tib.Drinks.Add("Coca");
    //         Tib.PrintCommand();


    //          */
            

    //         Command Tib = new Command ();

    //         Client jerem = new Client(01,"Jeremy","Antelois","14 rue du Faucon Bagnexu","0654787898");
    //         Commis phil = new Commis(01,"Phillipe","Arenoli");

    //         Pizza piz = new Pizza(7,"poupu","XL",17,"peperonni");
    //         Drink d = new Drink(7,"coca","XL",78);

    //         Tib.ClientInfos=jerem;
    //         Tib.CommisInfos=phil;

    //         Tib.addPizzas(piz);
    //         Tib.addDrinks(d);

    //         Tib.PrintCommand();

    //         Tib.CalculatePrice();
            
    //         Tib.PrintCommand();





    //     }

    // }


