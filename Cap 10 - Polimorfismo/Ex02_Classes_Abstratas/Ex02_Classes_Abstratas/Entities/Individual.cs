using System;
using System.Collections.Generic;
using System.Text;

namespace Ex02_Classes_Abstratas.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenses { get; set; }

        public Individual(string name, double income, double healthExpenses)
            : base (name, income)
        {
            HealthExpenses = healthExpenses;
        }

        public override double TaxPaid()
        {
            if (Income <= 20000.00)
            {
                return (Income * 0.15) - (HealthExpenses * 0.5);
            }
            else
            {
                return (Income * 0.25) - (HealthExpenses * 0.5);
            }
        }
    }
}
