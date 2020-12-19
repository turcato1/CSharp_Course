using System;
using System.Collections.Generic;
using System.Text;

namespace Ex02_Classes_Abstratas.Entities
{
    class Company : TaxPayer
    {
        public int NumEmployees { get; set; }

        public Company(string name, double income, int numEmployees)
            : base (name, income)
        {
            NumEmployees = numEmployees;
        }
        public override double TaxPaid()
        {
            if (NumEmployees > 10)
            {
                return Income * 0.14;
            }
            else
            {
                return Income * 0.16;
            }
        }
    }
}
