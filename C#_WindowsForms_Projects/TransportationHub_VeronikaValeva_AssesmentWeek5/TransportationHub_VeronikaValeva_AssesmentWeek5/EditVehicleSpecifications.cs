using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportationHub_VeronikaValeva_AssesmentWeek5
{
    public partial class EditVehicleSpecifications : Form
    {
        Vehicle vehicle;
        public EditVehicleSpecifications()
        {
            InitializeComponent();
            cbbAmountOfpassengers.Visible = false;
            txbWeight.Visible = false;
            txbVolume.Visible = false;
            lblPassengers.Visible = false;
            lblVolume.Visible = false;
            lblWeight.Visible = false;
        }

        public void SetVehicle(Vehicle v)
        {
            this.vehicle = v;
            rtxbCurrentSpecifications.Text = this.vehicle.GetFullInfo();
            if (vehicle is Car)
            {
                cbbAmountOfpassengers.Visible = true;
                txbWeight.Visible = false;
                txbVolume.Visible = false;
                lblPassengers.Visible = true;
                lblVolume.Visible = false;
                lblWeight.Visible = false;
            }
            else if (vehicle is Van)
            {
                cbbAmountOfpassengers.Visible = true;
                txbWeight.Visible = true;
                txbVolume.Visible = true;
                lblPassengers.Visible = true;
                lblVolume.Visible = true;
                lblWeight.Visible = true;
            }
            else if (vehicle is Truck)
            {
                cbbAmountOfpassengers.Visible = false;
                txbWeight.Visible = true;
                txbVolume.Visible = true;
                lblPassengers.Visible = false;
                lblVolume.Visible = true;
                lblWeight.Visible = true;
            }
        }

        private void EditVehicleSpecifications_Load(object sender, EventArgs e)
        {

        }

        private void btnSumbitChanges_Click(object sender, EventArgs e)
        {
            try
            {
                if (vehicle is Car)
                {
                    if (cbbAmountOfpassengers.SelectedIndex != -1)
                    { ((Car)vehicle).MaxPassengers = cbbAmountOfpassengers.SelectedIndex + 1; }
                    if (!String.IsNullOrEmpty(txbLicensePlate.Text))
                    { ((Car)vehicle).GetLicensePlate = txbLicensePlate.Text.ToString(); }
                    if (!String.IsNullOrEmpty(txbGasUsage.Text))
                    { ((Car)vehicle).GasUsagePerKm = Convert.ToDouble(txbGasUsage.Text);
                        ((Car)vehicle).PricePerKM = Convert.ToDouble(txbGasUsage.Text)*10; }
                }
                else if (vehicle is Van)
                {
                    if (cbbAmountOfpassengers.SelectedIndex != -1)
                    { ((Van)vehicle).MaxPassengers = cbbAmountOfpassengers.SelectedIndex + 1; }
                    if (!String.IsNullOrEmpty(txbWeight.Text))
                    { ((Van)vehicle).MaxWeight = Convert.ToDouble(txbWeight.Text); }
                    if (!String.IsNullOrEmpty(txbVolume.Text))
                    { ((Van)vehicle).MaxVolume = Convert.ToDouble(txbVolume.Text); }
                    if (!String.IsNullOrEmpty(txbLicensePlate.Text))
                    { ((Van)vehicle).GetLicensePlate = txbLicensePlate.Text.ToString(); }
                    if (!String.IsNullOrEmpty(txbGasUsage.Text))
                    { ((Van)vehicle).GasUsagePerKm = Convert.ToDouble(txbGasUsage.Text);
                        ((Van)vehicle).PricePerKM = Convert.ToDouble(txbGasUsage.Text)*10; }
                }
                else if (vehicle is Truck)
                {
                    if (!String.IsNullOrEmpty(txbWeight.Text))
                    { ((Truck)vehicle).MaxWeight = Convert.ToDouble(txbWeight.Text); }
                    if (!String.IsNullOrEmpty(txbVolume.Text))
                    { ((Truck)vehicle).MaxVolume = Convert.ToDouble(txbVolume.Text); }
                    if (!String.IsNullOrEmpty(txbLicensePlate.Text))
                    { ((Truck)vehicle).GetLicensePlate = txbLicensePlate.Text.ToString(); }
                    if (!String.IsNullOrEmpty(txbGasUsage.Text))
                    { ((Truck)vehicle).GasUsagePerKm = Convert.ToDouble(txbGasUsage.Text); 
                        ((Truck)vehicle).PricePerKM = Convert.ToDouble(txbGasUsage.Text)*10; }
                }
                this.Hide();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please set a correct input!");
            }
        }

        
    }
}
