using System;

namespace Ex03_Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter matrix order: ");
            int order = int.Parse(Console.ReadLine());

            int[,] intmat = new int[order, order];

            for (int i = 0; i < order; i++)
            {
                Console.Write($"Enter matrix row #{(i + 1)}: ");
                string currRow = Console.ReadLine();
                string[] inpVect = currRow.Split(' ');
                //ou, string currRow = Console.ReadLine().Split(' ');
                for (int j = 0; j < order; j++)
                {
                    intmat[i, j] = int.Parse(inpVect[j]);
                }
            }

            Console.WriteLine("Main diagonal:");
            for (int i = 0; i < order; i++)
            {
                Console.Write(intmat[i, i] + " ");
            }
            Console.WriteLine();

            Console.Write("Negative numbers = ");
            for (int i = 0; i < order; i++)
            {
                for (int j = 0; j < order; j++)
                {
                    if (intmat[i, j] < 0) Console.Write(intmat[i, j].ToString() + " ");
                }
            }
            Console.WriteLine();

        }
    }
}
