using System;
using System.Globalization;

namespace Ex04
{
    class Aluno
    {
        public string Nome;
        public double NotaT1;
        public double NotaT2;
        public double NotaT3;

        public double NotaFinal()
        {
            return NotaT1 + NotaT2 + NotaT3;
        }

        public string Aprovacao()
        {
            double PtosFaltantes;

            if (NotaFinal() >= 60)
            {
                return "APROVADO";
            }
            else
            {
                PtosFaltantes = (60.0 - NotaFinal());
                return "REPROVADO"
                    + "\r\n" + "FALTARAM "
                    + PtosFaltantes.ToString("F2", CultureInfo.InvariantCulture)
                    + " PONTOS";
            }
        }

        public override string ToString()
        {
            return "NOTA FINAL = "
                + NotaFinal().ToString("F2", CultureInfo.InvariantCulture)
                + "\r\n" + Aprovacao();
        }

    }
}
