using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Webshop
{
    class ProductFan
    {
        List<Product> productsToShow;
        List<Product> toysToShow;
        private double bargainLimit = 10;

        public double SetBargainLimit
        {
            set { bargainLimit = value; }
        }
        public ProductFan(ProductManager collection, bool ToyCollector)
        {
            if (ToyCollector)
            {
                collection.addProductSubscriber(ToyCollectorMessage);
                toysToShow = new List<Product>();
            } 
            else if (!ToyCollector)
            {
                collection.addProductSubscriber(BargainHunter); 
                productsToShow = new List<Product>();
            }

            // ----- ----- End of subscription to event.
        }
        

        private void ToyCollectorMessage(Product p)
        {
            if (p.GetTypeOfProduct == TypeOfProduct.toys)
            {
                toysToShow.Add(p);
                MessageBox.Show("added toy success");
            }
        }
       
        private void BargainHunter(Product p)
        {
            if (p.GetPrice <= bargainLimit)
            {
                productsToShow.Add(p);
                MessageBox.Show("added bargain success");
            }
        }

        public List<Product> GetListOfToys()
        {
            return this.toysToShow;
        }
        public List<Product> GetListOfBargains()
        {
            return this.productsToShow;
        }


    }
}
