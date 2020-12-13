using System;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Quarto[] vect_q = new Quarto[10];
            int numAlugados;
            int quarto = 0;

            //Pergunta quantos quartos serão alugados
            Console.Write("Quantos quartos serão alugados? ");
            numAlugados = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //Recebe os dados dos quartos alugados
            for (int i = 0; i < numAlugados; i++)
            {
                Console.WriteLine("Aluguel #" + (i + 1).ToString() + ":");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                quarto = int.Parse(Console.ReadLine());
                vect_q[quarto] = new Quarto(nome, email);
                Console.WriteLine();
            }

            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if (vect_q[i] != null)
                    Console.WriteLine(i.ToString() + ": " + vect_q[i].ToString());
            }


        }
    }
}
