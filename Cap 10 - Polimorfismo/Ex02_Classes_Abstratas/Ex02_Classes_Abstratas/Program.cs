using System;
using System.Globalization;
using System.Collections.Generic;
using Ex02_Classes_Abstratas.Entities;

namespace Ex02_Classes_Abstratas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cria lista de Tax Payers (Contribuintes)
            List<TaxPayer> TpList = new List<TaxPayer>();

            //Solicita entrada do número de Tax Payers
            Console.Write("Enter the number of tax payers: ");
            int inputTpNum = int.Parse( Console.ReadLine());

            //Coleta os dados dos Tax Payers
            for (int i = 1; i <= inputTpNum; i++)
            {
                // Informa e coleta dados básicos dos Tax Payers
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c): ");
                char inputTpType = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string inputTpName = Console.ReadLine();
                Console.Write("Annual income: ");
                double inputTpIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                // Diferencia a coleta de dados de acordo com o tipo de Tax Payer
                if (inputTpType == 'i')
                {
                    Console.Write("Health Expenditures: ");
                    double inputTpHealthExpenses = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    TpList.Add(new Individual(inputTpName, inputTpIncome, inputTpHealthExpenses));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int InputTpNumEmployees = int.Parse(Console.ReadLine());
                    TpList.Add(new Company(inputTpName, inputTpIncome, InputTpNumEmployees));
                }
                
            }
            
            //Imprime os resultados de Tax Payers cadastrados
            Console.WriteLine();
            Console.WriteLine("TAX PAID:");
            double sumTaxes = 0.0;
            foreach (TaxPayer tp in TpList)
            {
                Console.WriteLine(tp);
                sumTaxes += tp.TaxPaid();
            }

            // Imprime o total de impostos pagos
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sumTaxes.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
