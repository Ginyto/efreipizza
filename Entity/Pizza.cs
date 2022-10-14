using System;
    public class Pizza : Product
    {
        public string Description { get; set; }


        public Pizza(string name, double price, string description) : base(name, price)        
        {
            Description = description;
        }

        public Pizza(int num, string size ) : base(size)
        {
            switch (num)
            {
                case 1:
                    Name = "Margherita";
                    Price = 8.00;
                    Description = "Tomate, Mozzarella, Basilic";
                    break;
                case 2:
                    Name = "Reine";
                    Price = 9.00;
                    Description = "Tomate, Mozzarella, Jambon, Champignons";
                    break;
                case 3:
                    Name = "Napolitaine";
                    Price = 10.00;
                    Description = "Tomate, Mozzarella, Anchois, Olives";
                    break;
                case 4:
                    Name = "Calzone";
                    Price = 11.00;
                    Description = "Tomate, Mozzarella, Jambon, Champignons, Oeuf";
                    break;
            }

            Size = size;

            CalculatePrice(this);

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

