using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAboutPizzas
{
    public partial class FormExtra : Form
    {
        Pizza pizza;
        public FormExtra(Student s, Pizza p)
        {
            InitializeComponent();
            this.pizza = p;
            label1.Text = s.GetStudentName.ToString() + " " + s.StudentsNumber.ToString();
            label2.Text = p.GetInfo();
        }

        private void btnAddTopping_Click(object sender, EventArgs e)
        {
            string topping = tbTopping.Text.ToString();
            bool result = pizza.AddTopping(topping);
            if(result)
            {
                label2.Text = pizza.GetInfo();
            }
            else
            {
                MessageBox.Show("You have already added four toppings on your pizza!");
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
