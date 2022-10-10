namespace Projet {

    public abstract class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Size { get; set; }
        public int Id { get; set; }


        public Product(int id)
        {
            Console.WriteLine("\nProduit : \n");
            Console.WriteLine("Name: ");
            Name = Console.ReadLine();

            Console.WriteLine("Size: ");
            Size = Console.ReadLine();

            Console.WriteLine("Price : ");
            Price = Console.Read();

            Id = id;
        }

        public Product (int id, string name,string size, int price)
        {
            Id = id;
            Name = name;
            Size = size;
            Price = price;
        }

        public abstract void PrintProduct();
        public abstract void UpdateProduct();
    }

}