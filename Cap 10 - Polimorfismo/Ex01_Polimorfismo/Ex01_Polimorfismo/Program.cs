using System;
using System.Globalization;
using System.Collections.Generic;
using Ex01_Polimorfismo.Entities;

namespace Ex01_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> ProdList = new List<Product>();

            Console.Write("Enter the number of products: ");
            int nprod = int.Parse(Console.ReadLine());

            //Coleta produtos, tipos, preços e informações adicionais
            for (int i = 1; i <= nprod; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char prodtype = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string inputName = Console.ReadLine();
                Console.Write("Price: ");
                double inputPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                switch (prodtype)
                {
                    case 'i': //Importado
                        Console.Write("Customs fee: ");
                        double inputCustFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        ProdList.Add(new ImportedProduct(inputName, inputPrice, inputCustFee));
                        break;
                    case 'u': //Usado
                        Console.Write("Manufacture Date (DD/MM/YYYY): ");
                        DateTime inputManDate = DateTime.Parse(Console.ReadLine());
                        ProdList.Add(new UsedProduct(inputName, inputPrice, inputManDate));
                        break;
                    default:
                        ProdList.Add(new Product(inputName, inputPrice));
                        break;
                }
            }

            //Exibe produtos, tipos e preços
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product p in ProdList)
            {
                Console.WriteLine(p.PriceTag());
            }
        }
    }
}
