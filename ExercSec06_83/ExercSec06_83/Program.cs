using System;
using System.Collections.Generic;

namespace ExercSec06_83
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();
            HashSet<int> total = new HashSet<int>();
            int qtdCursos = 0;

            Console.Write("O curso A possui quantos alunos? ");
            qtdCursos = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso A:");

            for (int count = 0;count<qtdCursos;count++)
            {
                A.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("O curso B possui quantos alunos? ");
            qtdCursos = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso B: ");
            for (int count = 0; count < qtdCursos; count++)
            {
                B.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("O curso C possui quantos alunos? ");
            qtdCursos = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso C: ");
            for (int count = 0; count < qtdCursos; count++)
            {
                C.Add(int.Parse(Console.ReadLine()));
            }
            total.UnionWith(A);
            total.UnionWith(B);
            total.UnionWith(C);
            
            Console.Write("Total de alunos: {0} ", total.Count);
        }
    }
}
