using System;
using ExercSec09_122.Entities.Enums;
using System.Collections.Generic;
using System.Text;

namespace ExercSec09_122.Entities
{
    class Order
    {
        public DateTime moment { get; set; }
        public OrderStatus status { get; set; }
        public Client client { get; set; }
        public List<OrderItem> items { get; set; } = new List<OrderItem>();

        public Order()
        {

        }
        public Order(DateTime moment, OrderStatus status, Client client)
        {
            this.moment = moment;
            this.status = status;
            this.client = client;
        }

        public void addItem(OrderItem item)
        {
            items.Add(item);
        }

        public void removeItem(OrderItem item)
        {
            items.Remove(item);
        }

        public double total()
        {
            double total = 0.0;
            
            foreach (OrderItem item in items)
            {
                total = total + item.subTotal();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder sbString = new StringBuilder();
            sbString.AppendLine("ORDER SUMMARY");
            sbString.AppendLine("Order moment");
            sbString.Append(status);
            sbString.AppendLine("Client: ");
            sbString.Append(client);
            sbString.AppendLine("Order items");
            foreach (OrderItem item in items)
            {
                sbString.AppendLine(item.prodct.name);
            }
            sbString.AppendLine();
            return base.ToString();
        }
    }
}
