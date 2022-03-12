using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TransportationHub_VeronikaValeva_AssesmentWeek5
{
    public partial class Form1 : Form
    {
        TransportationHub transportationHub;
        EditVehicleSpecifications editVehicle;

        public Form1()
        {
            InitializeComponent();

            transportationHub = new TransportationHub();
            transportationHub.CreateLists();
            cbbAmountOfPersons.Visible = false;
            lblAmountOne.Visible = false;
            lblAmountTwo.Visible = false;
            txbAmountOne.Visible = false;
            txbAmountTwo.Visible = false;
            lblAmOne.Visible = false;
            lblAmTwo.Visible = false;
            lblAmThree.Visible = false;
            cbbAmountPassengers.Visible = false;
            txbWeight.Visible = false;
            txbVolume.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTypeOfTransportation.SelectedIndex == 0)
            {
                lblAmountOne.Visible = true;
                cbbAmountOfPersons.Visible = true;
                txbAmountOne.Visible = false; ;
                txbAmountTwo.Visible = false;
                lblAmountTwo.Visible = false;
                lblAmountOne.Text = "Amount of passengers:";

            }
            else
            {
                cbbAmountOfPersons.Visible = false;
                lblAmountOne.Visible = true;
                lblAmountTwo.Visible = true;
                txbAmountOne.Visible = true;
                txbAmountTwo.Visible = true;
                lblAmountOne.Text = "Volume of the cargo in m3:";
                lblAmountTwo.Text = "Weight of the cargo in kg:";
            }
        }

        private void btnAddvehicle_Click(object sender, EventArgs e)
        {
            string LicensePlatePattern = @"[A-Z]*\-[A-Z]*\-[0-9]*";
            if (!Regex.IsMatch(txbLicensePlate.Text.ToString(), LicensePlatePattern))
            {
                MessageBox.Show("Please enter a license plate number like the one in the following text: " +
                    "'KM-LM-450', 'KLM-HM-42' or 'E-L-7'.");
            }
            else
            {
                try
                {
                    string LicensePlate = txbLicensePlate.Text.ToString();
                    string MakeAndModel = txbBrandAndModel.Text.ToString();
                    string brand = MakeAndModel.Replace(' ', '-');
                    double GasUsagePerKm = Convert.ToDouble(txbGasUsagePerKm.Text);
                    int index = cbbTypeOfVehicle.SelectedIndex;
                    int MaxPassengers = 0;
                    double MaxWeight = 0;
                    double MaxVolume = 0;
                    if (txbWeight.Visible)
                    { MaxWeight = Convert.ToDouble(txbWeight.Text); }
                    if (txbVolume.Visible)
                    { MaxVolume = Convert.ToDouble(txbVolume.Text); }
                    if (cbbAmountPassengers.Visible)
                    { MaxPassengers = cbbAmountPassengers.SelectedIndex + 1; }
                    if (String.IsNullOrEmpty(brand))
                    { brand = "Not-specified"; }

                    if (transportationHub.AddVehicle(index, brand, LicensePlate,
                        GasUsagePerKm, MaxPassengers, MaxWeight, MaxVolume))
                    {
                        MessageBox.Show("Vehicle successfuly added!");

                    }
                    else if (!transportationHub.AddVehicle(index, brand, LicensePlate,
                        GasUsagePerKm, MaxPassengers, MaxWeight, MaxVolume))
                    {
                        MessageBox.Show("Failed to add a vehicle. Please try again.");
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please fill the fields with the correct format");
                }
            }

        }

        private void cbbTypeOfVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTypeOfVehicle.SelectedIndex == 0) //Car
            {
                lblAmOne.Text = "Max amount of passengers:";
                lblAmOne.Visible = true;
                cbbAmountPassengers.Visible = true;
                lblAmTwo.Visible = false;
                lblAmThree.Visible = false;
                txbVolume.Visible = false;
                txbWeight.Visible = false;
            }
            else if (cbbTypeOfVehicle.SelectedIndex == 1) //Van
            {
                lblAmOne.Text = "Max amount of passengers:";
                lblAmTwo.Text = "Max volume in m3:";
                lblAmThree.Text = "Max weight in kg:";
                lblAmOne.Visible = true;
                lblAmTwo.Visible = true;
                lblAmThree.Visible = true;
                cbbAmountPassengers.Visible = true;
                txbVolume.Visible = true;
                txbWeight.Visible = true;
            }
            else if (cbbTypeOfVehicle.SelectedIndex == 2) //Truck
            {
                lblAmTwo.Text = "Max volume in m3:";
                lblAmThree.Text = "Max weight in kg:";
                lblAmOne.Visible = false;
                lblAmTwo.Visible = true;
                lblAmThree.Visible = true;
                cbbAmountPassengers.Visible = false;
                txbVolume.Visible = true;
                txbWeight.Visible = true;
            }
        }

        private void btnAllVehicles_Click(object sender, EventArgs e)
        {
            lbxVehicles.Items.Clear();
            foreach (Vehicle vehicle in transportationHub.GetListOfAllVehicles().OrderBy(x => x.GetLicensePlate))
            {
                lbxVehicles.Items.Add(vehicle.GetInfo());
            }
        }

        private void cbbChoseVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAvalableVehicles_Click(object sender, EventArgs e)
        {
            lbxVehicles.Items.Clear();
            foreach (Vehicle vehicle in transportationHub.GetAvailableVehicles().OrderBy(x => x.GetLicensePlate))
            {
                lbxVehicles.Items.Add(vehicle.GetInfo());
            }
        }

        private void btnUnavailableVehicles_Click(object sender, EventArgs e)
        {
            lbxVehicles.Items.Clear();
            foreach (Vehicle vehicle in transportationHub.GetUnavailableVehicles().OrderBy(x => x.GetLicensePlate))
            {
                lbxVehicles.Items.Add(vehicle.GetInfo());
            }
        }

        private void cbbChoseVehicle_Click(object sender, EventArgs e)
        {
            cbbChoseVehicle.Items.Clear();
            foreach (Vehicle v in transportationHub.GetListOfAllVehicles())
            {
                cbbChoseVehicle.Items.Add(v.GetInfo());
            }

        }

        private void btnEditVehicleSpec_Click(object sender, EventArgs e)
        {
            editVehicle = new EditVehicleSpecifications();
            int index = cbbChoseVehicle.SelectedIndex + 1;
            foreach (Vehicle v in transportationHub.GetAvailableVehicles())
            {
                try
                {
                    if (v.ID == index)
                    {
                        editVehicle.SetVehicle(v);
                        editVehicle.Show();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Could not load form. Please try again.");
                    editVehicle.Hide();
                }
            }
            cbbChoseVehicle.Items.Clear();
            foreach (Vehicle v in transportationHub.GetListOfAllVehicles())
            {
                cbbChoseVehicle.Items.Add(v.GetInfo());
            }

        }

        private void btnStartTheRide_Click(object sender, EventArgs e)
        {
            double startingPrice = 1;
            int amountOfPassengers = -1;
            double volume = -1;
            double weight = -1;
            double AmOfKm = 0;
            DateTime startingDate = dtStartTime.Value;
            DateTime endDate = dtEndTime.Value;
            if (startingDate <= endDate)
            {
                try
                {
                    int index = cbbTypeOfTransportation.SelectedIndex;
                    if (cbbAmountOfPersons.Visible)
                    { amountOfPassengers = cbbAmountOfPersons.SelectedIndex + 1; }
                    if (txbAmountOne.Visible)
                    { volume = Convert.ToDouble(txbAmountOne.Text); }
                    if (txbAmountTwo.Visible)
                    { weight = Convert.ToDouble(txbAmountTwo.Text); }
                    if (!String.IsNullOrEmpty(txbStartingPrice.Text))
                    { startingPrice = Convert.ToDouble(txbStartingPrice.Text); }
                    if (!String.IsNullOrEmpty(txbAmountOfKm.Text))
                    { AmOfKm = Convert.ToDouble(txbAmountOfKm.Text); }
                    if (dtStartTime != null)
                    { startingDate = dtStartTime.Value; }
                    if (dtEndTime != null)
                    { endDate = dtEndTime.Value; }
                    if (transportationHub.AddRide(index, amountOfPassengers, volume, weight, startingPrice,
                        AmOfKm, startingDate, endDate))
                    { MessageBox.Show("Ride reserved successfuly!"); }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please fill the fields with the correct format.");
                }
            }
            else { MessageBox.Show("The starting date of your ride cannot be smaller than the ending date. Please try again."); }
        }

        private void btnCurrentRides_Click(object sender, EventArgs e)
        {
            rtxbCurrentRides.Text = String.Empty;
            foreach (Ride r in transportationHub.ListOfAllIncompleteRides().OrderBy(x => x.GetStartingDate))
            {
                rtxbCurrentRides.Text += r.GetRideInfo;
            }
            rtxbCurrentRides.Text += "\r\n";
        }


        private void btnSaveVehicle_Click(object sender, EventArgs e)
        {
            string filename;
            SaveFileDialog sfd = new SaveFileDialog();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                filename = sfd.FileName;
                transportationHub.WriteVehiclesToTextFile(filename);
            }
            else { MessageBox.Show("You chose CANCEL"); }
        }

        private void btnLoadVehicle_Click(object sender, EventArgs e)
        {
            string filename;
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filename = ofd.FileName;
                transportationHub.ReadVehicleFromTextFile(filename);
            }
            else { MessageBox.Show("You chose CANCEL"); }
        }

        private void btnCompletedRides_Click(object sender, EventArgs e)
        {
            rtxbCompletedRides.Text = String.Empty;
            foreach (Ride r in transportationHub.ListOfAllCompleteRides().OrderBy(x => x.GetStartingDate).ThenBy(x => x.GetKilometers))
            {
                rtxbCompletedRides.Text += r.GetRideInfo;
            }
        }

        private void btnSaveRide_Click(object sender, EventArgs e)
        {
            string filename;
            SaveFileDialog sfd = new SaveFileDialog();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                filename = sfd.FileName;
                transportationHub.WriteRidesToTextFile(filename);
            }
            else { MessageBox.Show("You chose CANCEL"); }
        }

        private void btnLoadRide_Click(object sender, EventArgs e)
        {
            string filename;
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filename = ofd.FileName;
                transportationHub.ReadRidesFromTextFile(filename);
            }
            else { MessageBox.Show("You chose CANCEL"); }
        }

        private void RideTimer_Tick(object sender, EventArgs e)
        {
            transportationHub.RideTimers();
        }

        private void btnDeleteVehicle_Click(object sender, EventArgs e)
        {
            int index = cbbChoseVehicle.SelectedIndex + 1;
            foreach (Vehicle v in transportationHub.GetAvailableVehicles())
            {
                try
                {
                    if (v.ID == index)
                    {
                        if (transportationHub.DeleteVehicle(v))
                        { MessageBox.Show("Vehicle deleted successfuly."); }
                        else { MessageBox.Show("Failed deleting vehicle. Try again."); }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed deleting vehicle. Try again.");
                }
            }
        }
    }
}
