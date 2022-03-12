using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeronikaValeva_DigitalShopingList
{
    public partial class Form1 : Form
    {
        List<string> Fruits = new List<string>();                        //Lists store the products based on their type
        List<string> Vegetables = new List<string>();                    //The types of products are fruits, vegetables, 
        List<string> Meat = new List<string>();                          //meat, dairy and other - products added by the user.
        List<string> Dairy = new List<string>();
        List<string> OtherPr = new List<string>();
        double FinalPrice = 0;                                           //This variable shows the price of all products

        string OldProductFR = "";                                       //These variables are used to remember the last product 
        string OldProductVG = "";                                       //added to the shopping cart based on their type. 
        string OldProductMT = "";
        string OldProductDR = "";
        string OldProductOTHR = "";

        int fruitCounter = 1;                                           //These variables keep track of the number of times a
        int vegetableCounter = 1;                                       //specific product is added or removed from the shopping cart
        int meatCounter = 1;
        int dairyCounter = 1;
        int otherCounter = 1;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)            
        {
            MessageBox.Show("Welcome to our online store!");           //This is a welcome message
        }
        public string GetProduct(string SelectedProduct)               //This method has one parameter and returns a string  
        {                                                              //with the name of the selected product
            string fruit = "";                                         //The method get the name of the product without the
            for (int i = 0; i < SelectedProduct.Length; i++)           //price os the product
            {
                if (SelectedProduct[i] != '-')
                {
                    fruit += SelectedProduct[i];
                }
                else if (SelectedProduct[i] == '-')
                {
                    break;
                }
            }
            return fruit;
        }

        public double GetProductPrice(string SelectProduct)              //This method has one parameter and returns a double 
        {                                                                //with the price of the selected product 
            string sum = "";                                             //It takes only the price of the product without its name
            double Price = 0;                                            //The name and the price are separated by a '-'
            for (int i = 0; i < SelectProduct.Length; i++)               //Everything before the '-' is considered to be part of the
            {                                                            //name of the product and everything afterwards is considered
                if (SelectProduct[i] == '-')                             //to be part of the price
                {                                                        //if the selected product happens to contain 'x' after 
                    for (int k = i + 1; k < SelectProduct.Length; k++)   //the '-', it is not considered part of the price
                    {
                        if (SelectProduct[k] != 'x')
                        {
                            sum += SelectProduct[k];
                            i++;
                        }
                        else
                        {
                            break;
                        }

                    }
                    Price = double.Parse(sum);
                }
            }
            return Price;
        }
        private void button2_Click(object sender, EventArgs e)
        {

            string FruitProduct = comboBox1.Text;
            string VegetableProduct = comboBox2.Text;
            string MeatProduct = comboBox4.Text;
            string DairyProduct = comboBox3.Text;
            string OtherProduct = comboBox5.Text;

            if (FruitProduct != "")
            {
                FruitSelector(FruitProduct);
            }
            if (VegetableProduct != "")
            {
                VegetableSelector(VegetableProduct);
            }
            if (MeatProduct != "")
            {
                MeatSelector(MeatProduct);
            }
            if (DairyProduct != "")
            {
                DairySelector(DairyProduct);
            }
            if (OtherProduct != "")
            {
                Other_Products_ComboBox(OtherProduct);
                OtherProductSelector(OtherProduct);
            }
            if (FavProducts.SelectedItems.Count == 1 && FavProducts.Items.Count != 0)
            {
                string Condition = "Add";
                string item = FavProducts.SelectedItem.ToString();
                FavProductSelector(item, Condition);
            }
            comboBox1.Text = string.Empty;
            comboBox2.Text = string.Empty;
            comboBox3.Text = string.Empty;
            comboBox4.Text = string.Empty;
            comboBox5.Text = string.Empty;
            FavProducts.ClearSelected();
        }

        public void FavProductSelector(string product, string Condition)
        {
            foreach (string fr in comboBox1.Items)
            {
                if (fr == product)
                {
                    if (Condition == "Add")
                    {
                        FruitSelector(fr);
                        break;
                    }
                    else if (Condition == "Delete")
                    {
                        DeleteFruit(fr);
                        break;
                    }
                }
            }
            foreach (string vg in comboBox2.Items)
            {
                if (vg == product)
                {
                    if (Condition == "Add")
                    {
                        VegetableSelector(vg);
                        break;
                    }
                    else if (Condition == "Delete")
                    {
                        DeleteVegetable(vg);
                        break;
                    }
                }
            }
            foreach (string mt in comboBox4.Items)
            {
                if (mt == product)
                {
                    if (Condition == "Add")
                    {
                        MeatSelector(mt);
                        break;
                    }
                    else if (Condition == "Delete")
                    {
                        DeleteMeat(mt);
                        break;
                    }
                }
            }
            foreach (string dr in comboBox3.Items)
            {
                if (dr == product)
                {
                    if (Condition == "Add")
                    {
                        DairySelector(dr);
                        break;
                    }
                    else if (Condition == "Delete")
                    {
                        DeleteDairy(dr);
                        break;
                    }
                }
            }
            foreach (string othr in comboBox5.Items)
            {
                if (othr == product)
                {
                    if (Condition == "Add")
                    {
                        OtherProductSelector(othr);
                        break;
                    }
                    else if (Condition == "Delete")
                    {
                        DeleteOtherProduct(othr);
                        break;
                    }
                }
            }
        }
        public void OtherProductSelector(string SelectedProduct)
        {
            double Price5 = GetProductPrice(SelectedProduct);
            bool NoProduct = true;
            foreach (string othr in OtherPr)
            {
                if (othr == SelectedProduct)
                {
                    NoProduct = false;
                    FinalPrice += Price5;
                    if (OtherProducts.Items.Contains(SelectedProduct))
                    {
                        otherCounter++;
                        OtherProducts.Items.Remove(SelectedProduct);
                        OtherProducts.Items.Add(SelectedProduct + " x" + otherCounter);
                        OldProductOTHR = SelectedProduct + " x" + otherCounter;
                    }
                    else
                    {
                        otherCounter++;
                        OtherProducts.Items.Remove(OldProductOTHR);
                        OtherProducts.Items.Add(SelectedProduct + " x" + otherCounter);
                        OldProductOTHR = SelectedProduct + " x" + otherCounter;
                    }
                }
            }
            if (NoProduct)
            {
                OldProductOTHR = SelectedProduct;
                OtherPr.Add(SelectedProduct);
                FinalPrice += Price5;
                OtherProducts.Items.Add(SelectedProduct);
            }
        }

        public void FruitSelector(string SelectedFruit)
        {
            double Price1 = GetProductPrice(SelectedFruit);
            bool NoFruit = true;
            foreach (string fr in Fruits)
            {
                if (fr == SelectedFruit)
                {
                    NoFruit = false;
                    FinalPrice += Price1;
                    if (FruitProducts.Items.Contains(SelectedFruit))
                    {
                        fruitCounter++;
                        FruitProducts.Items.Remove(SelectedFruit);
                        FruitProducts.Items.Add(SelectedFruit + " x" + fruitCounter);
                        OldProductFR = SelectedFruit + " x" + fruitCounter;
                    }
                    else
                    {
                        fruitCounter++;
                        FruitProducts.Items.Remove(OldProductFR);
                        FruitProducts.Items.Add(SelectedFruit + " x" + fruitCounter);
                        OldProductFR = SelectedFruit + " x" + fruitCounter;
                    }
                }
            }
            if (NoFruit)
            {
                OldProductFR = SelectedFruit;
                Fruits.Add(SelectedFruit);
                FinalPrice += Price1;
                FruitProducts.Items.Add(SelectedFruit);
            }
        }

        public void VegetableSelector(string SelectedVegetable)
        {
            string Vegetable = GetProduct(SelectedVegetable);
            double Price2 = GetProductPrice(SelectedVegetable);
            bool NoVegetable = true;
            foreach (string vg in Vegetables)
            {
                if (vg == SelectedVegetable)
                {
                    NoVegetable = false;
                    FinalPrice += Price2;
                    if (VegetableProducts.Items.Contains(SelectedVegetable))
                    {
                        vegetableCounter++;
                        VegetableProducts.Items.Remove(SelectedVegetable);
                        VegetableProducts.Items.Add(SelectedVegetable + " x" + vegetableCounter);
                        OldProductVG = SelectedVegetable + " x" + vegetableCounter;

                    }
                    else
                    {
                        vegetableCounter++;
                        VegetableProducts.Items.Remove(OldProductVG);
                        VegetableProducts.Items.Add(SelectedVegetable + " x" + vegetableCounter);
                        OldProductVG = SelectedVegetable + " x" + vegetableCounter;
                    }
                }
            }
            if (NoVegetable)
            {
                OldProductVG = SelectedVegetable;
                Vegetables.Add(SelectedVegetable);
                FinalPrice += Price2;
                VegetableProducts.Items.Add(SelectedVegetable);
            }
        }

        public void MeatSelector(string SelectedMeat)
        {
            double Price3 = GetProductPrice(SelectedMeat);
            bool NoMeat = true;
            foreach (string mt in Meat)
            {
                if (mt == SelectedMeat)
                {
                    NoMeat = false;
                    FinalPrice += Price3;


                    if (MeatProducts.Items.Contains(SelectedMeat))
                    {
                        meatCounter++;
                        MeatProducts.Items.Remove(SelectedMeat);
                        MeatProducts.Items.Add(SelectedMeat + " x" + meatCounter);
                        OldProductMT = SelectedMeat + " x" + meatCounter;
                    }
                    else
                    {
                        meatCounter++;
                        MeatProducts.Items.Remove(OldProductMT);
                        MeatProducts.Items.Add(SelectedMeat + " x" + meatCounter);
                        OldProductMT = SelectedMeat + " x" + meatCounter;
                    }
                }
            }
            if (NoMeat)
            {
                OldProductMT = SelectedMeat;
                Meat.Add(SelectedMeat);
                FinalPrice += Price3;
                MeatProducts.Items.Add(SelectedMeat);
            }
        }

        public void DairySelector(string SelectedDairy)
        {
            double Price4 = GetProductPrice(SelectedDairy);
            bool NoDairy = true;
            foreach (string dr in Dairy)
            {
                if (dr == SelectedDairy)
                {
                    NoDairy = false;
                    FinalPrice += Price4;
                    if (DairyProducts.Items.Contains(SelectedDairy))
                    {
                        dairyCounter++;
                        DairyProducts.Items.Remove(SelectedDairy);
                        DairyProducts.Items.Add(SelectedDairy + " x" + dairyCounter);
                        OldProductDR = SelectedDairy + " x" + dairyCounter;
                    }
                    else
                    {
                        dairyCounter++;
                        DairyProducts.Items.Remove(OldProductDR);
                        DairyProducts.Items.Add(SelectedDairy + " x" + dairyCounter);
                        OldProductDR = SelectedDairy + " x" + dairyCounter;
                    }
                }
            }
            if (NoDairy)
            {
                OldProductDR = SelectedDairy;
                Dairy.Add(SelectedDairy);
                FinalPrice += Price4;
                DairyProducts.Items.Add(SelectedDairy);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string item;
            string item1;
            double item2;
            string item3;
            if (FruitProducts.SelectedItems.Count == 1 && FruitProducts.Items.Count != 0)
            {
                item = FruitProducts.SelectedItem.ToString();
                item1 = GetProduct(item);
                item2 = GetProductPrice(item);
                item3 = item1 + "-" + item2;
                DeleteFruit(item3);
            }
            if (VegetableProducts.SelectedItems.Count == 1 && VegetableProducts.Items.Count != 0)
            {
                item = VegetableProducts.SelectedItem.ToString();
                item1 = GetProduct(item);
                item2 = GetProductPrice(item);
                item3 = item1 + "-" + item2;
                DeleteVegetable(item3);
            }
            if (MeatProducts.SelectedItems.Count == 1 && MeatProducts.Items.Count != 0)
            {
                item = MeatProducts.SelectedItem.ToString();
                item1 = GetProduct(item);
                item2 = GetProductPrice(item);
                item3 = item1 + "-" + item2;
                DeleteMeat(item3);
            }
            if (DairyProducts.SelectedItems.Count == 1 && DairyProducts.Items.Count != 0)
            {
                item = DairyProducts.SelectedItem.ToString();
                item1 = GetProduct(item);
                item2 = GetProductPrice(item);
                item3 = item1 + "-" + item2; 
                DeleteDairy(item3);
            }
            if (OtherProducts.SelectedItems.Count == 1 && OtherProducts.Items.Count != 0)
            {
                item = OtherProducts.SelectedItem.ToString();
                item1 = GetProduct(item);
                item2 = GetProductPrice(item);
                item3 = item1 + "-" + item2;
                DeleteOtherProduct(item3);
            }
            if (FavProducts.SelectedItems.Count == 1 && FavProducts.Items.Count != 0)
            {
                string Condition = "Delete";
                item = FavProducts.SelectedItem.ToString();
                FavProductSelector(item, Condition);
            }
            FavProducts.ClearSelected();
            FruitProducts.ClearSelected();
            VegetableProducts.ClearSelected();
            MeatProducts.ClearSelected();
            DairyProducts.ClearSelected();
            OtherProducts.ClearSelected();
        }

        public void DeleteOtherProduct(string DelProduct)
        {
            double Price5 = GetProductPrice(DelProduct);

            if (OtherProducts.Items.Contains(DelProduct))
            {
                OtherProducts.Items.Remove(DelProduct);
                if (DairyProducts.Items.Count == 0 && FruitProducts.Items.Count == 0 && VegetableProducts.Items.Count == 0 && MeatProducts.Items.Count == 0 && OtherProducts.Items.Count == 0)
                {
                    FinalPrice = 0;
                }
                else
                {
                    FinalPrice -= Price5;
                    OtherPr.Remove(DelProduct);
                }
            }
            else if (OtherProducts.Items.Contains(DelProduct + " x" + otherCounter))
            {
                OtherProducts.Items.Remove(DelProduct + " x" + otherCounter);
                otherCounter--;
                FinalPrice -= Price5;
                if (otherCounter > 1)
                {
                    OtherProducts.Items.Add(DelProduct + " x" + otherCounter);
                    OldProductOTHR = DelProduct + " x" + otherCounter;
                }
                else
                {
                    OtherProducts.Items.Add(DelProduct);
                }
            }
        }
        public void DeleteFruit(string DelFruit)
        {
            double Price1 = GetProductPrice(DelFruit);

            if (FruitProducts.Items.Contains(DelFruit))
            {
                FruitProducts.Items.Remove(DelFruit);
                if (DairyProducts.Items.Count == 0 && FruitProducts.Items.Count == 0 && VegetableProducts.Items.Count == 0 && MeatProducts.Items.Count == 0)
                {
                    FinalPrice = 0;
                }
                else
                {
                    FinalPrice -= Price1;
                   // Fruits.Remove(DelFruit);
                }
            }
            else if (FruitProducts.Items.Contains(DelFruit + " x" + fruitCounter))
            {
                FruitProducts.Items.Remove(DelFruit + " x" + fruitCounter);
                fruitCounter--;
                FinalPrice -= Price1;
                if (fruitCounter > 1)
                {
                    FruitProducts.Items.Add(DelFruit + " x" + (fruitCounter));
                    OldProductFR = DelFruit + " x" + (fruitCounter);
                }
                else
                {
                    FruitProducts.Items.Add(DelFruit);
                }
            }
        }
        public void DeleteVegetable(string DelVegetable)
        {
            double Price2 = GetProductPrice(DelVegetable);

            if (VegetableProducts.Items.Contains(DelVegetable))
            {
                VegetableProducts.Items.Remove(DelVegetable);
                if (DairyProducts.Items.Count == 0 && FruitProducts.Items.Count == 0 && VegetableProducts.Items.Count == 0 && MeatProducts.Items.Count == 0)
                {
                    FinalPrice = 0;
                }
                else
                {
                    FinalPrice -= Price2;
                    Vegetables.Remove(DelVegetable);
                }
            }
            else if (VegetableProducts.Items.Contains(DelVegetable + " x" + vegetableCounter))
            {
                VegetableProducts.Items.Remove(DelVegetable + " x" + vegetableCounter);
                vegetableCounter--;
                FinalPrice -= Price2;
                if (vegetableCounter > 1)
                {
                    VegetableProducts.Items.Add(DelVegetable + " x" + (vegetableCounter));
                    OldProductVG = DelVegetable + " x" + (vegetableCounter);
                }
                else
                {
                    VegetableProducts.Items.Add(DelVegetable);
                }
            }
        }
        public void DeleteMeat(string DelMeat)
        {
            double Price3 = GetProductPrice(DelMeat);

            if (MeatProducts.Items.Contains(DelMeat))
            {
                MeatProducts.Items.Remove(DelMeat);
                if (DairyProducts.Items.Count == 0 && FruitProducts.Items.Count == 0 && VegetableProducts.Items.Count == 0 && MeatProducts.Items.Count == 0)
                {
                    FinalPrice = 0;
                }
                else
                {
                    FinalPrice -= Price3;
                    Meat.Remove(DelMeat);
                }
            }
            else if (MeatProducts.Items.Contains(DelMeat + " x" + meatCounter))
            {
                MeatProducts.Items.Remove(DelMeat + " x" + meatCounter);
                meatCounter--;
                FinalPrice -= Price3;
                if (meatCounter > 1)
                {
                    MeatProducts.Items.Add(DelMeat + " x" + meatCounter);
                    OldProductMT = DelMeat + " x" + meatCounter;
                }
                else
                {
                    MeatProducts.Items.Add(DelMeat);
                }
            }
        }
        public void DeleteDairy(string DelDairy)
        {
            double Price4 = GetProductPrice(DelDairy);

            if (DairyProducts.Items.Contains(DelDairy))
            {
                DairyProducts.Items.Remove(DelDairy);
                if (DairyProducts.Items.Count == 0 && FruitProducts.Items.Count == 0 && VegetableProducts.Items.Count == 0 && MeatProducts.Items.Count == 0)
                {
                    FinalPrice = 0;
                }
                else
                {
                    FinalPrice -= Price4;
                    Dairy.Remove(DelDairy);
                }
            }
            else if (DairyProducts.Items.Contains(DelDairy + " x" + dairyCounter))
            {
                DairyProducts.Items.Remove(DelDairy + " x" + dairyCounter);
                dairyCounter--;
                FinalPrice -= Price4;
                if (dairyCounter > 1)
                {
                    DairyProducts.Items.Add(DelDairy + " x" + dairyCounter);
                    OldProductDR = DelDairy + " x" + dairyCounter;
                }
                else
                {
                    DairyProducts.Items.Add(DelDairy);
                }
            }
        }
        public void Other_Products_ComboBox(string SelectedOtherProduct)
        {
            if (!comboBox5.Items.Contains(SelectedOtherProduct))
            {
                comboBox5.Items.Add(SelectedOtherProduct);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = FinalPrice.ToString();
            string receipt = "Your bought:" + "\r\n";
            foreach (string fr in FruitProducts.Items)
            {
                receipt += "   ->  "  + fr + "\r\n";
            }
            foreach (string vg in VegetableProducts.Items)
            {
                receipt += "   ->  " + vg + "\r\n";
            }
            foreach (string mt in MeatProducts.Items)
            {
                receipt += "   ->  " + mt + "\r\n";
            }
            foreach (string dr in DairyProducts.Items)
            {
                receipt += "   ->  " + dr + "\r\n";
            }
            foreach (string othr in OtherProducts.Items)
            {
                receipt += "   ->  " + othr + "\r\n";
            }
            receipt += "The total sum is: " + FinalPrice;
            MessageBox.Show(receipt);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string FavFruit = comboBox1.Text;
            string FavVegetable = comboBox2.Text;
            string FavMeat = comboBox4.Text;
            string FavDairy = comboBox3.Text;
            string FavOthers = comboBox5.Text;

            if (FavFruit != "")
            {
                FavProducts.Items.Add(FavFruit);
            }
            if (FavVegetable != "")
            {
                FavProducts.Items.Add(FavVegetable);
            }
            if (FavMeat != "")
            {
                FavProducts.Items.Add(FavMeat);
            }
            if (FavDairy != "")
            {
                FavProducts.Items.Add(FavDairy);
            }
            if (FavOthers != "")
            {
                Other_Products_ComboBox(FavOthers);
                FavProducts.Items.Add(FavOthers);

            }
            comboBox1.Text = string.Empty;
            comboBox2.Text = string.Empty;
            comboBox3.Text = string.Empty;
            comboBox4.Text = string.Empty;
            comboBox5.Text = string.Empty;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (FavProducts.SelectedItems.Count == 1 && FavProducts.Items.Count != 0)
            {
                string RemoveFav = FavProducts.SelectedItem.ToString();
                FavProducts.Items.Remove(RemoveFav);
            }

        }
    }
}
