using System;
    public class Pizza : Product
    {
        public string Description { get; set; }


        public Pizza(string name, double price, string description) : base(name, price)        
        {
            Description = description;
        }

        public override void PrintProduct()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Size: {Size}");
            Console.WriteLine($"Description: {Description}");
        }
        
        public override void UpdateProduct()
        {
            

            PrintProduct();
        }

    }

