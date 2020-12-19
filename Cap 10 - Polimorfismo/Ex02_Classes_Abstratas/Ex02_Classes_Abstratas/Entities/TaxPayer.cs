using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Ex02_Classes_Abstratas
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double Income { get; set; }

        //Colocar "protected" para que esse construtor seja acessível somente à subclasse
        protected TaxPayer(string name, double income)
        {
            Name = name;
            Income = income;
        }

        public abstract double TaxPaid();

        public override string ToString()
        {
            return Name + ": $ " + TaxPaid().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
