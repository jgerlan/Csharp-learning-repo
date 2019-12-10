using System;
using ExercSec09_122.Entities.Enums;
using System.Collections.Generic;
using System.Globalization;
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
            sbString.AppendLine("\nORDER SUMMARY");
            sbString.Append("Order moment: ");
            sbString.Append(moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sbString.AppendLine();
            sbString.Append("Order Status: ");
            sbString.Append(status.ToString());
            sbString.AppendLine();
            sbString.Append("Client: ");
            sbString.Append(client);
            sbString.AppendLine();
            sbString.Append("Order items: ");
            foreach (OrderItem item in items)
            {
                sbString.AppendLine();
                sbString.Append(item.prodct.name+", ");
                sbString.Append("$"+item.price.ToString("F2", CultureInfo.InvariantCulture) + ", ");
                sbString.Append("Quantity: ");
                sbString.Append(item.quantity+", ");
                sbString.Append("Substotal: ");
                sbString.Append("$"+item.subTotal().ToString("F2", CultureInfo.InvariantCulture));
            }
            sbString.AppendLine();
            sbString.Append("Total price: ");
            double tl = this.total();
            sbString.Append("$"+tl.ToString("F2", CultureInfo.InvariantCulture));
            return sbString.ToString();
        }
    }
}
