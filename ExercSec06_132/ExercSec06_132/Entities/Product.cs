using System;
using System.Collections.Generic;
using System.Text;

namespace ExercSec06_132.Entities
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

        public string pricetag()
        {

            return "";
        }
    }
}
