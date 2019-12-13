using System;
using System.Globalization;
using System.Collections.Generic;
using ExercSec10_136.Entities;

namespace ExercSec10_136
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contribuinte> taxPayersList = new List<Contribuinte>();

            Console.Write("Enter the number of tax payers: ");
            int taxPayer = int.Parse(Console.ReadLine());


            for (int count = 1; count <= taxPayer; count++)
            {
                Console.WriteLine($"Tax payer #{count} data: ");
                Console.Write("Individual ou company (i/c)? ");
                char chooseContribute = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (chooseContribute == 'c')
                {
                    Console.Write("Number of employees: ");
                    int numberEmployees = int.Parse(Console.ReadLine());
                    taxPayersList.Add(new PessoaJuridica(name, anualIncome, numberEmployees));
                }
                else if(chooseContribute == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    taxPayersList.Add(new PessoaFisica(name, anualIncome, healthExpenditures));
                }

            }

            Console.WriteLine("\nTAXES PAID: ");
            double totalTaxes = 0.0;
            foreach (Contribuinte taxPay in taxPayersList)
            {
                Console.WriteLine(taxPay);
                totalTaxes = totalTaxes + taxPay.impostoPago();
            }
            Console.WriteLine("\nTOTAL TAXES: $ "+totalTaxes);
            
        }
    }
}
