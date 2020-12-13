using System;
using System.Globalization;

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\r\nDados do produto: " + p.ToString());

            Console.Write("\r\nDigite o número de produtos a ser adicionado ao estoque: ");
            p.AdicionarProdutos(int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("\r\nDados do produto: " + p.ToString());

            Console.Write("\r\nDigite o número de produtos a ser removido do estoque: ");
            p.RemoverProdutos(int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("\r\nDados do produto: " + p.ToString());

        }
    }
}
