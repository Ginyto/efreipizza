

using System;
namespace Projet
{
    public class Payment
    {
        private string ClientName { get; set; }
        private string ClientFirstName { get; set; }
        private string TypeOfPayment { get; set; }
        private double PriceOrder { get; set; }

        public Payment(string ClientName, string ClientFirstName, string TypeOfPayment,double PriceOrder)
        {
            this.ClientName=ClientName;
            this.ClientFirstName=ClientFirstName;
            this.TypeOfPayment=TypeOfPayment;
            this.PriceOrder=PriceOrder;
            
        }

        public void PrintDrink()
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