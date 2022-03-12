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
    public partial class Form1 : Form
    {
        BicycleParking bicycleParking;
        public Form1()
        {
            InitializeComponent();
            bicycleParking = new BicycleParking(2.50, 0.50);
        }

        private void btnParkBicycle_Click(object sender, EventArgs e)
        {
            BicycleType t = BicycleType.NORMAL;
            if(rbnElectric.Checked)
            {
                t = BicycleType.ELECTRIC;
            }
            else if(rbnFolding.Checked)
            {
                t = BicycleType.FOLDING;
            }
            else if(rbnNormal.Checked)
            {
                t = BicycleType.NORMAL;
            }
            else if(rbnTandem.Checked)
            {
                t = BicycleType.TANDEM;
            }
            string ticketNum = bicycleParking.ParkBicycle(t);
            lblTicketNumber.Text = ticketNum;
            cbbTicketnumbers.Items.Add(ticketNum);
        }

        private void btnRetrieveBicycle_Click(object sender, EventArgs e)
        {
            string ticketNum = cbbTicketnumbers.SelectedItem.ToString();
            RetrieveForm retrieveForm = new RetrieveForm(ticketNum, this.bicycleParking);
            retrieveForm.Show();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            string partialZipCode = tbxPartialZipcode.Text.ToString();
            StatisticsForm statistics = new StatisticsForm(partialZipCode, this.bicycleParking);
            statistics.Show();
        }
    }
}
