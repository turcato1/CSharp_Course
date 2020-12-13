using System;

namespace Ex03_Matrizes2
{
    class Program
    {

        // a b c d
        // e f g h
        // i j k l

        static void Main(string[] args)
        {
            Console.Write("Enter with matrix size as row <space> column: ");
            string[] vectMatDim = Console.ReadLine().Split(' ');

            //Cria a matriz com R x C, linhas x colunas
            int[,] mat = new int[int.Parse(vectMatDim[0]), int.Parse(vectMatDim[1])];

            //Preenche a matriz linha a linha
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                Console.Write($"Enter with values for row #{(i + 1)} ({mat.GetLength(1)} values): ");
                string[] currRow = Console.ReadLine().Split(' ');
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = int.Parse(currRow[j]);
                }
            }

            Console.Write("Type the value to identify its neighbours: ");
            int value = int.Parse(Console.ReadLine());

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (mat[i, j] == value)
                    {
                        // Número encontrado
                        Console.WriteLine($"Position {i}, {j}:");
                        //Left
                        if (j - 1 >= 0) Console.WriteLine("Left: " + mat[i, j - 1]);
                        //Right
                        if (j + 1 <= mat.GetLength(1) - 1) Console.WriteLine("Right: " + mat[i, j + 1]);
                        //Up
                        if (i - 1 >= 0) Console.WriteLine("Up: " + mat[i - 1, j]);
                        //Down
                        if (i + 1 <= mat.GetLength(0) - 1) Console.WriteLine("Down: " + mat[i + 1, j]);
                    }
                }
            }
        }
    }
}
