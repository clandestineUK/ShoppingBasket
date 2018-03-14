using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoppingBasketLibrary;

namespace ShoppingBasketUI
{
    public partial class ShoppingBasket : Form
    {
        public Basket basket = new Basket();
        BindingSource bs = new BindingSource();

        public ShoppingBasket()
        {
            InitializeComponent();

            bs.DataSource = basket.BasketItemList;

            lstBasket.DataSource = bs;    
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            basket.AddItemToBasket(txtName.Text, (int)qualUpDwn.Value, decimal.Parse(txtPrice.Text));
            //lstBasket.Items.Add(basket.BasketItemList[0]);

            bs.ResetBindings(false);
        }
    }
}
