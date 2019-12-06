using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace ExercSec5
{
    class Conta
    {
        public int NumeroConta { get; private set; }
        public string NomeTitular { get; set; }
        public double Saldo { get; private set; }

        public Conta() { }

        public Conta(int numeroConta, string nomeTitular)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
            //Saldo = 0;
        }

        public Conta(int numeroConta, string nomeTitular, double depositoInicial) : this (numeroConta, nomeTitular)
        {
            //NumeroConta = numeroConta;
            //NomeTitular = nomeTitular;
            DepositoSaldo(depositoInicial); ;
        }

        /*public int NumeroConta
        {
            get { return _numeroConta; }
            set
            {
                if (value != 0 && _numeroConta == 0)
                {
                    _numeroConta = value;
                }
            }
        }*/

        public void DepositoSaldo(double valorDeposito)
        {
            Saldo = Saldo + valorDeposito;
        }

        public void SaqueSaldo(double valorSaque)
        {
            if (valorSaque > 0)
            {
                Saldo = Saldo - 5.00 - valorSaque;
            }
        }

        public override string ToString()
        {
            return "Conta "
                + NumeroConta
                + ", Titular: "
                + NomeTitular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
