using System;
using System.Collections.Generic;
using System.Globalization;
using ExercSec06_132.Entities;

namespace ExercSec06_132
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int numberProducts = int.Parse(Console.ReadLine());

            for (int count = 1; count <= numberProducts; count++)
            {
                Console.WriteLine($"Product #{count} data:");
                Console.Write("Common, used or imported (c/u/i): ");
                char chooseType = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Price: ");
                double priceProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (chooseType == 'c')
                {
                    products.Add(new Product(nameProduct,priceProduct));
                }else if (chooseType == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime doTime = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(nameProduct, priceProduct, doTime));
                }else if (chooseType == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    products.Add(new ImportedProduct(nameProduct, priceProduct, customsFee));
                }
            }

            Console.WriteLine("PRICE TAGS");
            foreach (Product product in products)
            {
                Console.WriteLine(product.priceTag());
            }
        }
    }
}
