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
    public partial class EditWorkshopInformation : Form
    {
        Workshop workshop;
        PersonManager personManager;
        WorkshopManager workshopManager;
        public EditWorkshopInformation()
        {
            InitializeComponent();
            txbChangeAddress.Visible = false;
            txbChangeRoomNumber.Visible = false;
            lblAddress.Visible = false;
            lblRoomNumber.Visible = false;
        }
        public void SetWorkshop(Workshop w, PersonManager p, WorkshopManager wm)
        {
            this.workshop = w;
            this.personManager = p;
            this.workshopManager = wm;
            DetermineTypeOfWorkshop();
        }

        public void DetermineTypeOfWorkshop()
        {
            txbChangeTitle.Text = workshopManager.GetWorkshopTitle(workshop);
            rtxbChangeDescription.Text = workshopManager.GetWorkshopDescription(workshop);
            txbChangeCapacity.Text = workshopManager.GetWorkshopMaxCapacity(workshop).ToString();
            FillTeachersCombobox();
            cbbChangeTeachers.SelectedItem = $"{personManager.GetPersonNames(workshopManager.GetWorkshopTeacher(workshop))}, {personManager.GetPersonPCN(workshopManager.GetWorkshopTeacher(workshop))}";

            if (workshop.GetType() == typeof(InBuilding))
            {
                lblWorkshopPlace.Text = "InBuilding";
                txbChangeAddress.Visible = true;
                txbChangeRoomNumber.Visible = true;
                lblAddress.Visible = true;
                lblRoomNumber.Visible = true;
                txbChangeRoomNumber.Text = ((InBuilding)workshop).GetRoomNumber;
                txbChangeAddress.Text = ((InBuilding)workshop).GetAddress;
            }
            else
            {
                lblWorkshopPlace.Text = "Online";
            }

        }
        public void FillTeachersCombobox()
        {
            foreach (Person teacher in personManager.GetListOfAllPeople(TypeOfPerson.Teacher))
            {
                cbbChangeTeachers.Items.Add($"{personManager.GetPersonNames(teacher)}, {personManager.GetPersonPCN(teacher)}");
            }
        }

        private void cbbChangePlaceOfWorkshop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (workshop.GetType() == typeof(Online))
            {
                txbChangeAddress.Visible = false;
                txbChangeRoomNumber.Visible = false;
                lblAddress.Visible = false;
                lblRoomNumber.Visible = false;
            }
            else
            {
                txbChangeAddress.Visible = true;
                txbChangeRoomNumber.Visible = true;
                lblAddress.Visible = true;
                lblRoomNumber.Visible = true;
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txbChangeTitle.Text) || String.IsNullOrEmpty(rtxbChangeDescription.Text) ||
            (workshop.GetType() == typeof(InBuilding) && (String.IsNullOrEmpty(txbChangeAddress.Text) || String.IsNullOrEmpty(txbChangeRoomNumber.Text))))
                {
                    throw new NullOrEmptyInputException();
                }
                string title = txbChangeTitle.Text.ToString();
                string description = rtxbChangeDescription.Text.ToString();
                int capacity = Convert.ToInt32(txbChangeCapacity.Text.ToString());
                string[] teacher = cbbChangeTeachers.SelectedItem.ToString().Split(' ');
                int teacherPCN = Convert.ToInt32(teacher[teacher.Length - 1]);

                if (workshop.GetType() == typeof(InBuilding))
                {
                    string address = txbChangeAddress.Text.ToString();
                    string roomNumber = txbChangeRoomNumber.Text.ToString();
                    workshopManager.EditInBuildingWorkshopInfo(workshop, title, description, capacity, personManager.FindPerson(teacherPCN), address, roomNumber);
                }
                else
                {
                    workshopManager.EditOnlineWorkshopInfo(workshop, title, description, capacity, personManager.FindPerson(teacherPCN));
                }
                MessageBox.Show("Information changed!");
                this.Hide();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input.");
            }
            catch (NullOrEmptyInputException)
            {
                MessageBox.Show("Invalid input.");
            }
            catch (WorkshopCapacityException m)
            {
                MessageBox.Show(m.Message);
            }
            catch (PersonNotFoundException m)
            {
                MessageBox.Show(m.Message);
            }
            catch (WorkshopNotFoundException m)
            {
                MessageBox.Show(m.Message);
            }
        }

    }
}

