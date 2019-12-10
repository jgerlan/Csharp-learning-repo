using System;
using System.Globalization;
using ExercSec09_122.Entities;
using ExercSec09_122.Entities.Enums;

namespace ExercSec09_122
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberItemsOrder;
            string name;
            string email;
            DateTime dateBirth;
            DateTime nowTime = DateTime.Now;
            OrderStatus status;
                        
            Console.WriteLine("Enter cliente data: ");
            Console.WriteLine("Name:");
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Email: )");
            email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            dateBirth = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, dateBirth); 
            
            Console.Write("Enter order data: ");
            nowTime.ToString("DD/MM/YYYY HH:mm:ss");
            Console.Write("Status: ");
            status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order?");
            numberItemsOrder = int.Parse(Console.ReadLine());

            Order order = new Order(nowTime, status, client);
            
            for (int count = 0; count < numberItemsOrder; count++)
            {
                Console.WriteLine($"Enter #{count+1 } item data");
                Console.Write("Product name: ");
                string nameItem = Console.ReadLine();
                Console.Write("Product price: ");
                double itemPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Quantity: ");
                int qtdItem = int.Parse(Console.ReadLine());

                Product product = new Product(nameItem, itemPrice);
                OrderItem orderItem = new OrderItem(qtdItem, itemPrice, product);

                order.addItem(orderItem);
                // order.addItem();

            }

            
        }
    }
}
