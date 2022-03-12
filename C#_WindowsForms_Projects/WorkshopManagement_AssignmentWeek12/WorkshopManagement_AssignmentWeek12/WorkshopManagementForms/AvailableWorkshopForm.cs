using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkshopManagement_AssignmentWeek12
{
    public partial class AvailableWorkshopForm : Form
    {
        WorkshopSubscriber workshopSubscriber;
        
        public AvailableWorkshopForm(WorkshopManager workshopManager)
        {
            InitializeComponent();
            workshopSubscriber = new WorkshopSubscriber(workshopManager);
            this.ShowAllWorkshops();
            this.ControlBox = false;
        }


        public void ShowAllWorkshops()
        {
            lbxAvailableWorkshops.Items.Clear();
            foreach (Workshop workshop in workshopSubscriber.GetListOfAvailableWorkshops())
            {
                if (workshop.IsWorkshopStarted == false)
                {
                    lbxAvailableWorkshops.Items.Add(workshop.ToString());
                }
            }
        }

        private void btnShowOnlineWorkshops_Click(object sender, EventArgs e)
        {
            lbxAvailableWorkshops.Items.Clear();
            foreach (Workshop workshop in workshopSubscriber.GetListOfAvailableWorkshops())
            {
                if (workshop.GetType() == typeof(Online) && workshop.IsWorkshopStarted == false)
                {
                    lbxAvailableWorkshops.Items.Add(workshop.ToString());
                }

            }
        }

        private void btnShowInBuildingWokrshops_Click(object sender, EventArgs e)
        {
            lbxAvailableWorkshops.Items.Clear();
            foreach (Workshop workshop in workshopSubscriber.GetListOfAvailableWorkshops())
            {
                if (workshop.GetType() == typeof(InBuilding) && workshop.IsWorkshopStarted == false)
                {
                    lbxAvailableWorkshops.Items.Add(workshop.ToString());
                }

            }
        }

        private void btnShowAllWorkshops_Click(object sender, EventArgs e)
        {
            this.ShowAllWorkshops();
        }
    }
}
