using System;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define os objetos da classe Pessoa
            Pessoa pessoa1, pessoa2;

            //Instancia os objetos da classe Pessoa na memória
            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();

            //Colhe nome e idade das pessoas
            Console.Write("Nome da pessoa 1: ");
            pessoa1.Nome = Console.ReadLine();
            Console.Write("Idade da pessoa 1: ");
            pessoa1.Idade = int.Parse(Console.ReadLine());
            Console.Write("Nome da pessoa 2: ");
            pessoa2.Nome = Console.ReadLine();
            Console.Write("Idade da pessoa 2: ");
            pessoa2.Idade = int.Parse(Console.ReadLine());

            if (pessoa1.idade > pessoa2.idade)
            {
                Console.WriteLine("Pessoa mais velha: " + pessoa1.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + pessoa2.Nome);
            }
        }
    }
}
