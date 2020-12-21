using System;
using System.Collections.Generic;
using System.Text;

namespace Ex01_Arquivos.Entities
{
    class Item
    {
        public string ProdName { get; set; }
        public double UnitValue { get; set; }
        public int Quantity { get; set; }

        public Item(string prodName, double unitValue, int quantity)
        {
            ProdName = prodName;
            UnitValue = unitValue;
            Quantity = quantity;
        }

        public double Subtotal()
        {
            return UnitValue * Quantity;
        }
    }
}
