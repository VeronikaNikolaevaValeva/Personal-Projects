using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Webshop
{
    partial class BargainHunterForm : Form
    {
        ProductFan productFan;
        private double priceLimit = 10;
        public BargainHunterForm(ProductManager collection)
        {
            InitializeComponent();
            productFan = new ProductFan(collection, false);
            ShowProducts();
        }

        public void ShowProducts()
        {
            lbBargains.Items.Clear();
            foreach (Product p in productFan.GetListOfBargains())
            {
                if(p.GetPrice <= priceLimit)
                {lbBargains.Items.Add(p.GetInfo); }
                
            }
        }

        private void tbPriceLimit_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            productFan.SetBargainLimit = Convert.ToDouble(tbPriceLimit.Text);
            priceLimit = Convert.ToDouble(tbPriceLimit.Text);
        }
    }
}
