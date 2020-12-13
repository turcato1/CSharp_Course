using System;
using System.Globalization;
using Ex01_Enum.Entities;
using Ex01_Enum.Entities.Enum;

namespace Ex01_Enum
{
    class Program
    {
        static void Main(string[] args)
        {

            //Instancia um cliente "newClient" da classe Client
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string clientEmail = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime clientBirthDate = DateTime.Parse(Console.ReadLine());
            Client newClient = new Client(clientName, clientEmail, clientBirthDate);

            //Cria um novo pedido "order"
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order newOrder = new Order(DateTime.Now, status, newClient);

            //Requisita o número de itens de "order"
            Console.Write("How many items in this order: ");
            int nItems = int.Parse(Console.ReadLine());

            //Adiciona itens ao pedido order
            for (int i = 1; i <= nItems; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string prodName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Product product = new Product(prodName, price);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                OrderItem newItem = new OrderItem(quantity, price, product);
                newOrder.AddItem(newItem);
            }

            //Exibe o resumo do pedido
            Console.WriteLine();
            Console.WriteLine(newOrder.ToString());

        }
    }
}
