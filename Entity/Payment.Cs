

using System;
namespace Projet
{
    public class Payment
    {
        public string ClientName { get; set; }
        public string ClientFirstName { get; set; }
        public string TypeOfPayment { get; set; }
        public double PriceOrder { get; set; }

        public Payment(string ClientName, string ClientFirstName, string TypeOfPayment,double PriceOrder)
        {
            this.ClientName=ClientName;
            this.ClientFirstName=ClientFirstName;
            this.TypeOfPayment=TypeOfPayment;
            this.PriceOrder=PriceOrder;
            
        }

        public void PrintPayment()
    {
        Console.WriteLine($"ClientName: {ClientName}");
        Console.WriteLine($"ClientFirstName: {ClientFirstName}");
        Console.WriteLine($"TypeOfPayment: {TypeOfPayment}");   
        Console.WriteLine($"PriceOrder: {PriceOrder}");   
    }
     public double MakePayment(){
        return PriceOrder;

     }
    }
}