using System;

namespace ExercSec06_71
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudante[] estudantes = new Estudante[10];
            int numeroDeQuartos;

            Console.Write("Quantos quartos vão ser alugados?");
            numeroDeQuartos = int.Parse(Console.ReadLine());

            
            for (int loopCount = 0; loopCount < numeroDeQuartos; loopCount++)
            {
                Console.WriteLine($"Estudante # {loopCount+1}");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email:");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                estudantes[quarto] = new Estudante(nome, email);
                //Console.WriteLine(loopCount + ": " + estudantes[quarto]);
            }

            for (int Count = 0; Count < 10; Count++)
            {
                if (estudantes[Count] != null) 
                {
                    Console.WriteLine(Count +": "+ estudantes[Count]);
                }
            }

        }
    }
}
