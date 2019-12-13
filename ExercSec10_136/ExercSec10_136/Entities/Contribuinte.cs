
namespace ExercSec10_136.Entities
{
    abstract class Contribuinte
    {
        public string nome { get; set; }
        public double rendaAnual { get; set; }

        protected Contribuinte()
        {
        }

        public Contribuinte(string nome, double rendaAnual)
        {
            this.nome = nome;
            this.rendaAnual = rendaAnual;
        }

        public abstract double impostoPago();
    }
}
