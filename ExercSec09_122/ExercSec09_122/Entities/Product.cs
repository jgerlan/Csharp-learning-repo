using System;


namespace ExercSec09_122.Entities
{
    class Product
    {
        public string name { get; set; }
        public double price { get; set; }

        public Product()
        {

        }

        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
    }
}
