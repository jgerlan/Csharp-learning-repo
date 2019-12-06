using System;
using System.Globalization;

namespace ExercSec5
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta;
            int numeroConta = 0;
            string titular = string.Empty;
            double deposito = 0.0;
            double saque = 0.0;
            char haDepositoInicial;
            

            //while (true)
            //{
                conta = new Conta();

                Console.Write("Entre com o número da conta: ");
                numeroConta = int.Parse(Console.ReadLine());
                Console.Write("Entre com o titular da conta: ");
                titular = Console.ReadLine();
                Console.Write("Haverá depósito inicial (s/n): ");
                haDepositoInicial = char.Parse(Console.ReadLine());

                if (haDepositoInicial == 's' || haDepositoInicial == 'S')
                {
                    Console.Write("Entre com o valor inicial: ");
                    deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    conta = new Conta(numeroConta, titular, deposito);
                }else
                {
                    conta = new Conta(numeroConta, titular);
                }

                //Console.WriteLine("\nDados da conta:\nConta:" + conta.NumeroConta + " Titular: " + conta.NomeTitular + " Saldo: " + conta.Saldo);
                Console.WriteLine("\nDados da conta: ");
                Console.WriteLine(conta);


                Console.Write("Entre com um valor para deposito:");
                conta.DepositoSaldo(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

                Console.Write("Entre um valor para Saque (Taxa $5.00):");
                conta.SaqueSaldo(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

                //Console.WriteLine("\nDados da conta atualizados:\nConta:" + conta.NumeroConta + " Titular: " + conta.NomeTitular + " Saldo: " + conta.Saldo);
                Console.WriteLine("\nDados da conta atualizados: ");
                Console.WriteLine(conta);
            //}


        }
    }
}
