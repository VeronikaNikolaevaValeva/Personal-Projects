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
    partial class WebshopForm : Form
    {
        ProductManager productManager;
        ToyCollectorForm toyCollector;
        BargainHunterForm bargainHunter;
        public WebshopForm()
        {
            InitializeComponent();
           this.productManager = new ProductManager();
            toyCollector = new ToyCollectorForm(productManager);
            bargainHunter = new BargainHunterForm(productManager);
            toyCollector.Show(); 
            bargainHunter.Show();
        }

        private void UpdateGUI()
        {
            
            toyCollector.ShowProducts();
            bargainHunter.ShowProducts();
           
        }

        private void WebshopForm_Activated(object sender, EventArgs e)
        {
            UpdateGUI();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                productManager.AddProduct(tbName.Text.ToString(), (TypeOfProduct)(cbProductType.SelectedIndex),
                    Convert.ToInt32(tbStock.Text), Convert.ToDouble(tbPrice.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input!");
            }
            UpdateListBox();


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = tbName.Text.ToString();
            double price = 0;
            if (!String.IsNullOrEmpty(tbPrice.Text))
            { price = Convert.ToDouble(tbPrice.Text); }
            int quantity = 0;
            if (!String.IsNullOrEmpty(tbStock.Text))
            { quantity = Convert.ToInt32(tbStock.Text); }
            if (lbProducts.SelectedIndex != -1)
            {
                try
                {
                    productManager.UpdateProductInformation(Convert.ToInt32(lbProducts.SelectedIndex + 1),
                       name, price, quantity);
                }
               catch (Exception)
                {
                    MessageBox.Show("Invalid input!");
                }
            }
            UpdateListBox();


        }

        private void lbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void UpdateListBox()
        {
            lbProducts.Items.Clear();
            foreach (Product product in productManager.GetListOfAllProducts)
            {
                lbProducts.Items.Add(product.GetInfo);
            }
            tbName.Text = String.Empty;
            tbPrice.Text = String.Empty;
            tbStock.Text = String.Empty;
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            
        }
    }
}
