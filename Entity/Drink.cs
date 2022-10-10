
    
    public class Drink : Product
    {

        public Drink(string name, double price) : base(name, price){}


        public override void PrintProduct()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Size: {Size}");
        }
        public override void UpdateProduct()
        {
            
        }

    }

