using System;
using System.Collections.Generic;
using System.Globalization;
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

        public virtual string priceTag()
        {
            StringBuilder sbString = new StringBuilder();
            sbString.Append(name + " ");
            sbString.Append("$ "+price.ToString("F2", CultureInfo.InvariantCulture));
            return sbString.ToString() ;
        }
    }
}
