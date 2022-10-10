namespace Projet
{

    public class Command
    {
        public int OrderNumber { get; set; }
        public string Time { get; set; }
        public string Date { get; set; }
        public Commis CommisInfos { get; set; }
        public Client ClientInfos { get; set; }
        public List<Pizza> Pizzas = new List<Pizza>();
        public List<Drink> Drinks = new List<Drink>();
        public double PriceOrder { get; set; }
        public int State { get; set; }  //state 0 = prise en charge commande , 1 = préparation commande , 2 = en livraison , 3 = livrée



        public Command(int ordernumber, string time, string date, Commis commisinfos,Client clientinfos, string clientfirstname, List<Pizza> pizzas, List<Drink> drinks, double priceorder, int state)
        {
            this.OrderNumber=ordernumber;
            this.Time=time;
            this.Date=date;
            this.CommisInfos=commisinfos;
            this.ClientInfos=clientinfos;
            this.Pizzas=pizzas;
            this.Drinks=drinks;
            this.PriceOrder=priceorder;
            this.State=state;                      
        }

        public Command()
        {

        }

        public void addPizzas(Pizza p)
        {  
            Pizzas.Add(p);
        }

        public void addDrinks(Drink d)
        {  
            Drinks.Add(d);
        }

        public void CalculatePrice()
        {
            int TotalPrice = 0;

            foreach(Pizza p in Pizzas)
                TotalPrice = TotalPrice + p.Price;

            foreach(Drink d in Drinks)
                TotalPrice = TotalPrice + d.Price;
            
            PriceOrder = TotalPrice;
        }


        public void PrintCommand()
        {    
            Console.WriteLine($"\nCommand number : {OrderNumber}");

            switch(State) 
            {
                case 0:
                    Console.WriteLine($"State : In preparation");
                    break;
                case 1:
                    Console.WriteLine($"State : In delivery");
                    break;
                case 2:
                    Console.WriteLine($"State : Delivered");
                    break;

                default : 
                    Console.WriteLine($"Lost command");
                    break;           
            }

            Console.WriteLine($"------------------------------------------");
            Console.WriteLine($"Time : {Time}");
            Console.WriteLine($"Date : {Date}");
            Console.WriteLine($"Commis : {CommisInfos.Name} {CommisInfos.FirstName}");
            Console.WriteLine($"ClientName : {ClientInfos.Name} {ClientInfos.FirstName}");

            Console.WriteLine($"------------------------------------------");

            Console.WriteLine($"Pizzas :");
            foreach(var p in Pizzas)
                Console.WriteLine($"- ID : {p.Id} , Pizza : {p.Name}, Price : {p.Price}, Size : {p.Size}, Description : {p.Description}"); 
            Console.WriteLine($"------------------------------------------");
            Console.WriteLine($"Drinks :");
            foreach(var d in Drinks)
                Console.WriteLine($"- ID : {d.Id} , Drink : {d.Name}, Price : {d.Price}, Size : {d.Size}"); 
            Console.WriteLine($"------------------------------------------");
            Console.WriteLine($"PriceOrder : {PriceOrder} $ \n");   
        }

    }
    
    public class Program
    {

        public static void Main(string[] args)
        {

            /**

            ArrayList Pizzas = new ArrayList() {"hawaienne", "reine"};
            ArrayList Drinks = new ArrayList() {"coca", "sprite"};


            ArrayList Pizzasss = new ArrayList() {"hawaienne", "reine"};
            ArrayList Drinksss = new ArrayList() {"coca", "sprite"};


            Command command = new Command(12, "19h03", "22/08", "Steve", "Phillipe", "Olivier", Pizzas, Drinks, 27, 0);
            Command command2 = new Command(13, "19h07", "22/08", "Anim", "Orima", "Karim", Pizzasss, Drinksss, 21, 2);

            command.PrintCommand();
            command2.PrintCommand();

            Tib.addPizzas
            Tib.addDrinks


            

            
            Tib.Pizzas.Add("Pizzi");
            Tib.Drinks.Add("Coca");
            Tib.PrintCommand();


             */
            

            Command Tib = new Command ();

            Client jerem = new Client(01,"Jeremy","Antelois","14 rue du Faucon Bagnexu","0654787898");
            Commis phil = new Commis(01,"Phillipe","Arenoli");

            Pizza piz = new Pizza(7,"poupu","XL",17,"peperonni");
            Drink d = new Drink(7,"coca","XL",78);

            Tib.ClientInfos=jerem;
            Tib.CommisInfos=phil;

            Tib.addPizzas(piz);
            Tib.addDrinks(d);

            Tib.PrintCommand();

            Tib.CalculatePrice();
            
            Tib.PrintCommand();





        }

    }
}

