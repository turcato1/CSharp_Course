using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Ex01_Enum.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product OrderProduct { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product orderProduct)
        {
            Quantity = quantity;
            Price = price;
            OrderProduct = orderProduct;
        }
        
        public double subTotal()
        {
            return Price * Quantity;
        }
        
        public override string ToString()
        {
            return OrderProduct.Name
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + Quantity
                + ", Subtotal: $"
                + subTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
