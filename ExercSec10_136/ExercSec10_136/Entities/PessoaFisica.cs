using System.Globalization;
using System.Text;

namespace ExercSec10_136.Entities
{
    class PessoaFisica : Contribuinte
    {
        public double gastosSaude { get; set; }

        public PessoaFisica()
        {
        }

        public PessoaFisica(string nome, double rendaAnual, double gastosSaude)
            : base (nome, rendaAnual)
        {
            this.gastosSaude = gastosSaude;
        }

        public override double impostoPago()
        {
            double imposto;
            if (this.rendaAnual < 20000.00)
            {
                imposto = this.rendaAnual * 0.15;
                if (this.gastosSaude != 0.0)
                    imposto = imposto - (this.gastosSaude *  0.5);
            }
            else
            {
                imposto = this.rendaAnual * 0.25;
                if (this.gastosSaude != 0.0)
                    imposto = imposto - (this.gastosSaude * 0.5);
            }

            return imposto;
        }

        public override string ToString()
        {
            StringBuilder sbString = new StringBuilder();
            sbString.Append(nome+": ");
            sbString.Append("$ "+this.impostoPago().ToString("F2", CultureInfo.InvariantCulture));
            return sbString.ToString();
        }
    }
}
