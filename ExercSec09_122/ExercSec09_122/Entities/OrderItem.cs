using System;
using System.Collections.Generic;
using System.Text;

namespace ExercSec09_122.Entities
{
    class OrderItem
    {
        public int quantity { get; set; }
        public double price { get; set; }
        public Product prodct { get; set; }

        public OrderItem()
        {

        }

        public OrderItem(int quantity, double price, Product prodct)
        {
            this.quantity = quantity;
            this.price = price;
            this.prodct = prodct;
        }

        public double subTotal()
        {
            return quantity * price;
        }
    }
}
