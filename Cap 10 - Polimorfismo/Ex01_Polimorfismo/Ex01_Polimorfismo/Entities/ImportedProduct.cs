﻿using System;
using System.Globalization;

namespace Ex01_Polimorfismo.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }
        public ImportedProduct()
        {
        }
        public ImportedProduct(string name, double price, double customsfee)
            : base(name, price)
        {
            CustomsFee = customsfee;
        }
        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
        public override string PriceTag()
        {
            return Name + " $ " + TotalPrice().ToString("F2", CultureInfo.InvariantCulture) 
                + " (Customs fee: $ " + CustomsFee.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }

    }
}
