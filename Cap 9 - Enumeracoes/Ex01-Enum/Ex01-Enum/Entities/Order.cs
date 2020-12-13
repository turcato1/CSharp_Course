using System;
using System.Text;
using System.Globalization;
using System.Collections.Generic;
using Ex01_Enum.Entities.Enum;


namespace Ex01_Enum.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> ItemsList { get; private set; } = new List<OrderItem>();
        public Client OrderClient { get; set; }

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client orderClient)
        {
            Moment = moment;
            Status = status;
            OrderClient = orderClient;
        }
        
        public void AddItem(OrderItem orderItem)
        {
            ItemsList.Add(orderItem);
        }
        public void RemoveItem(OrderItem orderItem)
        {
            ItemsList.Remove(orderItem);
        }
        public double Total()
        {
            double orderTotal = 0.0;
            foreach (OrderItem item in ItemsList)
            {
                orderTotal += item.subTotal();
            }
            return orderTotal;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.AppendLine(OrderClient.ToString());
            sb.AppendLine("Order items:");
            foreach (OrderItem item in ItemsList)
            {
                sb.AppendLine(item.ToString());
            }
            sb.Append("Total price: $");
            sb.AppendLine(Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
