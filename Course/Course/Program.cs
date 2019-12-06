using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string option = "1";
            string [] listTest = new string[5];
            listTest[0] = "Course -Construtor, sobrecarga e uso do THIS (1)";
            listTest[1] = "Course -Encapsulamento (2)";
            listTest[2] = "Course -Propriedades (3)";
            listTest[3] = "Course -Auto Propriedades (4)";

            Console.WriteLine("Escolha o teste do curso de C#");
            int count = 0;
            foreach (string element in listTest)
            {
                Console.WriteLine($"{element}");
                count++;
            }
            option = Console.ReadLine();

            if (option == "1")
            {
                CourseConstrSobrecThis();
            }else if (option == "2")
            {
                Encapsulamento();
            }else if (option== "3")
            {
                Propriedades();
            }else if (option=="4")
            {
                AutoPropriedades();
            }
        }

        static void CourseConstrSobrecThis()
        {
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            //Produto p1 = new Produto();
            Produto p = new Produto(nome, preco, quantidade);
            Produto p2 = new Produto(nome, preco);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }

        static void Encapsulamento()
        {
            Produto2 pDois = new Produto2("Carro", 500000, 10);
            Console.WriteLine(pDois.GetNome());
            pDois.SetNome("Tesla");
            Console.WriteLine(pDois.GetNome());
        }

        static void Propriedades()
        {
            Produto3 pTres = new Produto3("Carro", 500000, 10);
            Console.WriteLine(pTres.Nome);
            pTres.Nome="Tesla";
            Console.WriteLine(pTres.Nome);
        }

        static void AutoPropriedades()
        {
            Produto3 pTres = new Produto3("Carro", 500000, 10);
            Console.WriteLine(pTres.Nome);
            pTres.Nome = "Tesla";
            Console.WriteLine(pTres.Nome);
        }
    }
}