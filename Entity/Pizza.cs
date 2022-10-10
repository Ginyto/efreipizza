namespace Projet {

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
            Console.WriteLine("\nYou are updating the Product: " + Name + "\nPress enter to skip" + "\n");

            Console.WriteLine("Price modification : ");
            int price = Console.Read();
            Price = price; 

            Console.WriteLine("Size Modification : ");
            string size = Console.ReadLine();
            if (!String.IsNullOrEmpty(size)){ Size = size; }

            Console.WriteLine("\n***Product updated!***\n");

            PrintProduct();
        }

    }

}