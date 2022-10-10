namespace Projet {
    public class Drink : Product
    {
        public Drink(int id) : base(id){}

        public Drink(int id, string name, string size, int price) : base(id, name, size, price)        
        {

        }

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

}