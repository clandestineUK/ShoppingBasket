using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasketLibrary
{
    public class BasketItem
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal UnitCost { get; set; }

        public decimal TotalCost
        {
            get
            {
                return UnitCost * Quantity;
            }
        }


        public BasketItem(string name, int quantity, decimal unitCost)
        {
            Name = name;
            Quantity = quantity;
            UnitCost = unitCost;
        }

        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2:C}\t{3:C}",
                this.Name, this.Quantity, this.UnitCost, this.TotalCost);
        }

    }
}
