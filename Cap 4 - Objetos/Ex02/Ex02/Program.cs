using System;
using System.Globalization;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declara os objetos da classe Funcionario
            Funcionario func1, func2;

            //Instancia na memória os objetos
            func1 = new Funcionario();
            func2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome : ");
            func1.Nome = Console.ReadLine();
            Console.Write("Salário : ");
            func1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome : ");
            func2.Nome = Console.ReadLine();
            Console.Write("Salário : ");
            func2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salMedio = (func1.Salario + func2.Salario) / 2.0;
            Console.WriteLine("Salário médio = " + salMedio.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
