using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasketLibrary
{
    public class Basket
    {
        public List<BasketItem> BasketItemList = new List<BasketItem>();

        public decimal BasketTotal
        {
            get
            {
                decimal retVal = 0;
                foreach(BasketItem bI in BasketItemList)
                {
                    retVal += bI.TotalCost;
                }
                return retVal;
            }
        }

        public int ItemCount
        {
            get
            {
                return BasketItemList.Count();
            }
        }

        public void AddItemToBasket(string name, int quantity, decimal unitCost)
        {
            //Add validation here

            BasketItem itm = new BasketItem(name, quantity, unitCost);

            BasketItemList.Add(itm);
        }


    }
}
