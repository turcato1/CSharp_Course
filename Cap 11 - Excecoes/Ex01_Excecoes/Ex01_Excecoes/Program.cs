using System;
using System.Globalization;
using Ex01_Excecoes.Entities;

namespace Ex01_Excecoes
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                //Cadastramento da conta
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int inpNumber = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string inpName = Console.ReadLine();
                Console.Write("Initial balance: ");
                double inpBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double inpWithdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //Cria nova conta
                Account newAccount = new Account(inpNumber, inpName, inpBalance, inpWithdrawLimit);

                //Operação de saque solicitada
                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double inpWithdrawAmount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //Tenta a operação de saque
                newAccount.Withdraw(inpWithdrawAmount);

                //Caso tenha passado pelas exceções, mostra o saldo atual
                Console.WriteLine("New balance: " + newAccount.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Input format error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
