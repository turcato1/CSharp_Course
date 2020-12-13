using System;

namespace Primeiro //Namespace: não é obrigatório, serve para agrupar classes relacionadas
{
    class Program //Class: bloco básico da programação C#
    {
        // ---- aqui vão os membros da classe acima, nesse exemplo da classe Program
        static void Main(string[] args) //Esse membro é o entry point da aplicação, onde a execução inicia
        {
            Console.WriteLine("Hello World!");

            //Anotações:
            // NomeDoDevice = Pascal Case
            // nomeDoDevice = Camel Case
            // Console.WriteLine("{0} tem valor {1:F2}", nomeDoDevice, valor); = Placeholder

        }
    }
}
