
using System;
namespace Projet
{
    public class Cooker
    {
        public int CookerNumber { get; set; }
       

        public Cooker(int CookerNumber)
        {
            this.CookerNumber=CookerNumber;
    
        }

        public void PrintCookerNumber()
    {
        Console.WriteLine($"CookerNumber: {CookerNumber}");
       
    }
     public void prepare(){
        Console.WriteLine($"Preparing command");
     }
    }
}