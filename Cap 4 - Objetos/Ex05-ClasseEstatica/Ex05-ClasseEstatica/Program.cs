using System;
using System.Globalization;

namespace Ex05_ClasseEstatica
{
    class Program
    {
        static void Main(string[] args)
        {
            double CotacaoDig;
            double DolaresDig;


            Console.Write("Qual a cotação do dólar? ");
            CotacaoDig = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            DolaresDig = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Valor a ser pago em reais = " + ConversorDeMoeda.DolarParaReais(DolaresDig, CotacaoDig).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
