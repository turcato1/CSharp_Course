using System;
using System.Collections.Generic;
using System.Text;

namespace Ex05_ClasseEstatica
{
    class ConversorDeMoeda
    {
        static double Iof = 0.06;

        public static double DolarParaReais(double dolares, double cotacao)
        {
            return (dolares * cotacao) * (1 + Iof);
        }
    }
}
