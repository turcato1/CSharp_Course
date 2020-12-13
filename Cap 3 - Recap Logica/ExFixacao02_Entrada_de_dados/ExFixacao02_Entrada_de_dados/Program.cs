using System;

namespace ExFixacao02_Entrada_de_dados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            string[] NomeIdadeAlt = Console.ReadLine().Split(' ');

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco);
            Console.WriteLine(NomeIdadeAlt[0]);
            Console.WriteLine(int.Parse(NomeIdadeAlt[1]));
            Console.WriteLine(double.Parse(NomeIdadeAlt[2]));

        }
    }
}
