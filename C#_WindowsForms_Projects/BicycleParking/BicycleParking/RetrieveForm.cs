using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BicycleParking
{
    public partial class RetrieveForm : Form
    {
        
        private string tNum = "";
        private BicycleParking bp;
        public RetrieveForm(string ticketNum, BicycleParking b)
        {
            InitializeComponent();
            tNum = ticketNum;
            this.bp = b;
        }

        private void btnRetrieveBicycle_Click(object sender, EventArgs e)
        {
            int hoursParking = int.Parse(tbxHoursInParking.Text);
            string ownerZipcode = tbxOwnerZipcode.Text.ToString();
            double price = bp.RetrieveBicycle(tNum, hoursParking, ownerZipcode);
            MessageBox.Show($"The total cost is: {price}");
            this.Hide();
        }
    }
}
