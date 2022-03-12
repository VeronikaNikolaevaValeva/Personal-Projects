using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop
{
    class ProductManager
    {
        private List<Product> products;
        private int serialNum = 1;

        public delegate void NewProductHandler(Product p);
        private event NewProductHandler newProductAdded;
        

        public ProductManager()
        {
            products = new List<Product>();
        }

        public Product FindProduct(int serialNum)
        {
            foreach (Product product in products)
            {
                if (product.GetSerialNumber == serialNum)
                { return product; }
            }
            return null;
        }

        public List<Product> GetListOfAllProducts
        {
            get { return this.products; }
        }
        public bool AddProduct(string name, TypeOfProduct typeOfProduct, int quantity, double price)
        {
            if (FindProduct(serialNum) == null)
            {
                Product product = new Product(serialNum, name, typeOfProduct, quantity, price);
                products.Add(product);
                serialNum++;
                this.notifyArrivalNewProduct(product);
                
                return true;
            }
            return false;
        }

        private void notifyArrivalNewProduct(Product p)
        {
            NewProductHandler pr = this.newProductAdded;

            if (pr != null)
            { pr(p); }

        }
        
        public void addProductSubscriber(NewProductHandler pr)
        {
            this.newProductAdded += pr;
        }
        
        

        public bool BuyItem(int boughtQuantity, int serialNum)
        {
            if (FindProduct(serialNum) != null)
            {
                if (boughtQuantity <= FindProduct(serialNum).GetQuantity)
                {
                    FindProduct(serialNum).GetQuantity -= boughtQuantity;
                    return true;
                }
            }
            return false;
        }

        public bool UpdateProductInformation(int serialNum, string name, double price, int quantity)
        {
            if (FindProduct(serialNum) != null)
            {
                if(!String.IsNullOrEmpty(name))
                {FindProduct(serialNum).GetName = name; }
                if(price!=0)
                {FindProduct(serialNum).GetPrice = price; }
                if(quantity!=0)
                {FindProduct(serialNum).GetQuantity = quantity;}
                return true;
            }
            return false;
        }


        public string GetProductInfo(int serialNum)
        {
            return FindProduct(serialNum).GetInfo;
        }



    }
}
