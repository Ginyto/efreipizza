using System;
    
    public class Drink : Product
    {

        public Drink(string name, double price) : base(name, price){}

        public Drink(int num, string size) : base(size)
        {
            switch (num)
            {
                case 1:
                    Name = "Coca";
                    Price = 2.00;
                    break;
                case 2:
                    Name = "Fanta";
                    Price = 2.00;
                    break;
                case 3:
                    Name = "Sprite";
                    Price = 2.00;
                    break;
                case 4:
                    Name = "Eau";
                    Price = 1.00;
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
        }
        public override void UpdateProduct()
        {
            
        }

    }

