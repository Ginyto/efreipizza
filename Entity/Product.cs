namespace Projet {

    public abstract class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Size { get; set; } = "S";


        public Product()
        {
            Console.WriteLine("\nProduit : \n");
            Console.WriteLine("Name: ");
            Name = Console.ReadLine();

            Console.WriteLine("Size: ");
            Size = Console.ReadLine();

            Console.WriteLine("Price : ");
            Price = Console.Read();

        }

        public Product (string name, double price)
        {
            Name = name;
            Price = price;

        }

        public void Extra(int extra){
            Price += extra;
        }

        public abstract void PrintProduct();
        public abstract void UpdateProduct();
    }

}