using System;
using System.Globalization;

namespace ExFixacao01_Saida_de_dados
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";
            
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("{0}, cujo preço é $ {1:F2}", produto1, preco1);
            Console.WriteLine($"{produto2} cujo preço é {preco2:F2}");
            Console.WriteLine("Registro: {0} anos de idade, código {1} e gênero {2}", idade, codigo, genero);
            Console.WriteLine($"Medida com oito casas decimais {medida:F8}");
            Console.WriteLine($"Medida com oito casas decimais {medida:F3}");
            Console.WriteLine($"Medida com oito casas decimais {medida.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}
