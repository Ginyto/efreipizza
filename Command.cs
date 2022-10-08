namespace Projet
{

    public class Command
    {
        public string ClientName { get; set; }
        public string ClientFirstName { get; set; }
        public string TypeOfCommand { get; set; }
        public double PriceOrder { get; set; }

        public Command(string ClientName, string ClientFirstName, string TypeOfCommand,double PriceOrder)
        {
            this.ClientName=ClientName;
            this.ClientFirstName=ClientFirstName;
            this.TypeOfCommand=TypeOfCommand;
            this.PriceOrder=PriceOrder;
            
        }

        public void PrintCommand()
    {
        Console.WriteLine($"ClientName: {ClientName}");
        Console.WriteLine($"ClientFirstName: {ClientFirstName}");
        Console.WriteLine($"TypeOfCommand: {TypeOfCommand}");   
        Console.WriteLine($"PriceOrder: {PriceOrder}");   
    }
     public double MakeCommand(){
        return PriceOrder;

     }
    }
    
}