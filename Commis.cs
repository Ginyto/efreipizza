

using Internal;
using System;
namespace Projet
{
    public class Commis
    {
        public string name { get; set; }
       

        public Commis(string name)
        {
            this.name=name;
    
        }

        public void PrintCommis()
    {
        Console.WriteLine($"CookerNumber: {name}");
       
    }
     public void TakeOrder(){}
    public void SendClientConfirmationMessage(){}
    public void SendPizzaConfirmationMessage(){}
    public void SendOpenOrderMessage(){}
    public void SendPayementMessage(){}
    public void SendClosedCommandMeesage(){}

}
}