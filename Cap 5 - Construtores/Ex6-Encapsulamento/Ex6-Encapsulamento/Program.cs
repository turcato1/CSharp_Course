using System;
using System.Globalization;

namespace Ex6_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            string nome = null;
            double depinicial = 0.0;
            Conta c;

            Console.Write("Entre o número da conta: ");
            numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n): ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre o valor do depósito inicial: ");
                depinicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new Conta(numero, nome, depinicial);
            }
            else
            {
                c = new Conta(numero, nome);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(c);
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Entre com um valor para depósito: ");
            c.Depositar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c); // Não precisa ser c.ToString()
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Entre com um valor para saque: ");
            c.Sacar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c);
            Console.WriteLine();

        }
    }
}
