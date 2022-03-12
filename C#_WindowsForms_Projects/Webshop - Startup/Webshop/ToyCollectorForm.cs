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
    partial class ToyCollectorForm : Form
    {
        ProductFan productFan;
        public ToyCollectorForm(ProductManager collection)
        {
            InitializeComponent();
            productFan = new ProductFan(collection, true);
            ShowProducts();
        }
        public void ShowProducts()
        {
            lbToys.Items.Clear();
            foreach(Product p in productFan.GetListOfToys())
            {
                lbToys.Items.Add(p.GetInfo);
            }
        }

        
    }
}
