using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop
{
    class Product
    {
        private int serialNumber;
        private string name;
        private TypeOfProduct productType;
        private int quantity;
        private double price;
        

        public int GetSerialNumber
        {
            get { return this.serialNumber; }
        }
        public double GetPrice
        {
            set { this.price = value; }
            get { return this.price; }
        }

        public string GetName
        {
            set { this.name = value.ToString(); }
            get { return this.name; }
        }

        public int GetQuantity
        {
            set { this.quantity = value; }
            get { return this.quantity; }
        }

        public TypeOfProduct GetTypeOfProduct
        {
            get { return this.productType; }
        }
        public Product(int serialNum, string name, TypeOfProduct typeOfProduct, int quantity, double price)
        {
            this.serialNumber = serialNum;
            this.name = name;
            this.productType = typeOfProduct;
            this.quantity = quantity;
            this.price = price;
        }

        public string GetInfo
        {
            get { return $"Name: {this.name}, Price: {this.price}, Type: {this.productType}, Stock: {this.quantity}"; }
        }
        



    }
}
