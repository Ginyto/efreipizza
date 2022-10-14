using System;
    public abstract class Product
    {
        public string Name { get; set; }
        public double Price { get; set; } = 0.00;
        public string Size { get; set; } = "S";

        public Product (string name, double price)
        {
            Name = name;
            Price = price;

        }

        public Product(){}

        public Product(string Size){}

        public void CalculatePrice(Product product)
        {
            switch (product.Size)
            {
                case "S":
                    product.Price += 0.00;
                    break;

                case "M":
                    product.Price += 1.00;
                    break;

                case "L":
                    product.Price += 4.00;
                    break;
                    
                case "XL":
                    product.Price += 5.00;
                    break;
            }

        }

        public abstract void PrintProduct();
        public abstract void UpdateProduct();
    }

