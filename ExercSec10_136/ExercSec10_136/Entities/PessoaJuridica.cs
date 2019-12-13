using System;
using System.Collections.Generic;
using System.Text;

namespace ExercSec10_136.Entities
{
    class PessoaJuridica : Contribuinte
    {
        public int numeroFuncionarios { get; set; }

        public PessoaJuridica()
        {
        }

        public PessoaJuridica(string nome, double rendaAnual, int numeroFuncionarios)
            : base (nome, rendaAnual)
        {
            this.numeroFuncionarios = numeroFuncionarios;
        }

        public override double impostoPago()
        {
            double imposto;

            if (this.numeroFuncionarios<=10)
            {
                imposto = this.rendaAnual * 0.16;
            }
            else
            {
                imposto = this.rendaAnual * 0.14;
            }

            return imposto;
        }
    }
}
