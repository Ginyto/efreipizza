using System;
    public abstract class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Size { get; set; } = "S";

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

