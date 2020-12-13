using System;
using System.Globalization;

namespace Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();

            Console.Write("Nome do aluno: ");
            a.Nome = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Digite as três notas:");
            a.NotaT1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.NotaT2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.NotaT3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(a.ToString());

        }
    }
}
