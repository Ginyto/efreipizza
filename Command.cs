namespace Projet
{

    public class Command
    {
        public int OrderNumber { get; set; }
        public string Time { get; set; }
        public string Date { get; set; }
        public string CommisName { get; set; }
        public string ClientName { get; set; }
        public string ClientFirstName { get; set; }
        public List<string> Pizzas { get; set; }
        public List<string> Drinks { get; set; }
        public double PriceOrder { get; set; }
        public int State { get; set; }  //state 0 = prise en charge commande , 1 = préparation commande , 2 = en livraison , 3 = livrée



        public Command(int ordernumber, string time, string date, string commisname,string clientname, string clientfirstname, List<string> pizzas, List<string> drinks, double priceorder, int state)
        {
            this.OrderNumber=ordernumber;
            this.Time=time;
            this.Date=date;
            this.CommisName=commisname;
            this.ClientName=clientname;
            this.ClientFirstName=clientfirstname;
            this.Pizzas=pizzas;
            this.Drinks=drinks;
            this.PriceOrder=priceorder;
            this.State=state;          
            
        }

        public void PrintCommand()
    {    
        Console.WriteLine($"\nCommand number : {OrderNumber}");

        switch(State) {
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
        Console.WriteLine($"ClerckName : {CommisName}");
        Console.WriteLine($"ClientName : {ClientName}");
        Console.WriteLine($"ClientFirstName : {ClientFirstName}");

        Console.WriteLine($"------------------------------------------");

        Console.WriteLine($"Pizzas :");
        foreach(var piz in Pizzas)
            Console.WriteLine($"- {piz}"); 
        Console.WriteLine($"------------------------------------------");
        Console.WriteLine($"Drinks :");
        foreach(var dri in Drinks)
            Console.WriteLine($"- {dri}"); 
        Console.WriteLine($"------------------------------------------");
        Console.WriteLine($"PriceOrder : {PriceOrder} $ \n");   
    }




     public double MakeCommand(){
        return PriceOrder;

     }
    }


    public class ListOfCommand
    {
        public List<Command> CommandList { get; set; }
    }
    
}

