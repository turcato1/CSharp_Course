using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using Ex01_Arquivos.Entities;

namespace Ex01_Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceFilePath = @"..\..\..\Files\List.csv";
            string destinationPath = @"..\..\..\Files\out";
            List<Item> SourceItems = new List<Item>();

            try
            {
                Console.WriteLine("Reading source file " + Path.GetFullPath(sourceFilePath) + " ...");
                string[] sourceFileLines = File.ReadAllLines(sourceFilePath);
                Console.WriteLine("Processing file data... ");
                foreach (string line in sourceFileLines)
                {
                    string[] lineVector = line.Split(",");
                    string lineItemName = lineVector[0];
                    double lineItemPrice = double.Parse(lineVector[1], CultureInfo.InvariantCulture);
                    int lineItemQuantity = int.Parse(lineVector[2]);
                    SourceItems.Add(new Item(lineItemName, lineItemPrice, lineItemQuantity));
                }
                try
                {
                    Console.WriteLine("Creating subdirectory 'out'... ");
                    Directory.CreateDirectory(destinationPath);

                    Console.WriteLine(@"Creating output file out\summary.csv... ");
                    using (FileStream fs = new FileStream(destinationPath + @"\summary.csv", FileMode.Create)) 
                    {
                        using (StreamWriter sw = new StreamWriter(fs))
                        {
                            Console.WriteLine("Writing data in output file... ");
                            foreach (Item item in SourceItems)
                            {
                                sw.WriteLine(item.ProdName + "," + item.Subtotal().ToString("F2", CultureInfo.InvariantCulture));
                            }
                        }
                    }
                    Console.WriteLine("Output file complete");
                }
                catch (IOException e)
                {
                    Console.WriteLine("Error writing output file: " + e.Message);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error in reading file: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error in file data: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }

        }
    }
}
