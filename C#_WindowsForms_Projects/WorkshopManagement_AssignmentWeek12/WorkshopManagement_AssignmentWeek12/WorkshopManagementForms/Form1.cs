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
    public partial class WorkshopManagerForm : Form
    {
        public PersonManager personManager;
        public WorkshopManager workshopManager;
        EditWorkshopInformation editWorkshopInformation;
        EditPersonInformation editPersonInformation;
        AvailableWorkshopForm availableWorkshopForm;
        public WorkshopManagerForm()
        {
            InitializeComponent();
            personManager = new PersonManager();
            workshopManager = new WorkshopManager();
            personManager.SetListOfPeople = new List<Person>();
            workshopManager.SetObjectReference();
            availableWorkshopForm = new AvailableWorkshopForm(workshopManager);
            availableWorkshopForm.Show();
            HideControls();
        }
        private void WorkshopManagerForm_Activated(object sender, EventArgs e)
        {
            availableWorkshopForm.ShowAllWorkshops();
        }
        public void HideControls()
        {
            txbAddress.Visible = false;
            txbRoomNumber.Visible = false;
            lblAddress.Visible = false;
            lblRoomNumber.Visible = false;
            lblChooseStudent.Visible = false;
            gbxAllStudents.Visible = false;
            gbxShowCertainWorkshopInfo.Visible = false;
            UpdateTeacherComboBox();
        }

        //------------------------------RegisterPerson

        private void btnAddRegisterPerson_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txbNames.Text) || String.IsNullOrEmpty(txbPCN.Text) || cbbTypeOfPerson.SelectedIndex == -1)
                {
                    throw new NullOrEmptyInputException();
                }
                if(cbbTypeOfPerson.SelectedItem.ToString() != TypeOfPerson.Teacher.ToString() && cbbTypeOfPerson.SelectedItem.ToString() != TypeOfPerson.Student.ToString())
                {
                    throw new PersonNotFoundException();
                }
                else
                {
                    string names = txbNames.Text.ToString();
                    int pcn = Convert.ToInt32(txbPCN.Text);
                    TypeOfPerson typeOfPerson = (TypeOfPerson)(cbbTypeOfPerson.SelectedIndex);
                    personManager.AddPerson(pcn, names, typeOfPerson);
                    UpdateListOfAllPeople();
                    UpdateTeacherComboBox();
                    ClearTextboxesPerson();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input for the PCN.");
            }
            catch (NullOrEmptyInputException m)
            {
                MessageBox.Show(m.Message);
            }
            catch (ExistingPersonException m)
            {
                MessageBox.Show("This pcn is already used.");
            }
            catch (PersonNotFoundException m)
            {
                MessageBox.Show(m.Message);
            }
            catch (OverflowException)
            {
                MessageBox.Show("The pcn input is out of boundaries.");
            }
        }

        public void UpdateListOfAllPeople()
        {
            lbAllPeople.Items.Clear();
            foreach (Person person in personManager.GetListOfPeople())
            {
                lbAllPeople.Items.Add(personManager.GetPersonInfo(person));
            }
        }

        private void btnShowTeachers_Click(object sender, EventArgs e)
        {
            lbAllPeople.Items.Clear();
            foreach (Person person in personManager.GetListOfAllPeople(TypeOfPerson.Teacher))
            {
                lbAllPeople.Items.Add(personManager.GetPersonInfo(person));
            }
        }

        private void btnShowStudents_Click(object sender, EventArgs e)
        {
            lbAllPeople.Items.Clear();
            foreach (Person person in personManager.GetListOfAllPeople(TypeOfPerson.Student))
            {
                lbAllPeople.Items.Add(personManager.GetPersonInfo(person));
            }
        }

        private void btnShowAllPeople_Click(object sender, EventArgs e)
        {
            UpdateListOfAllPeople();
        }
        private void btnEditPersonInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbAllPeople.SelectedIndex == -1)
                {
                    throw new NullOrEmptyInputException();
                }
                string[] personInfo = lbAllPeople.SelectedItem.ToString().Split(' ');
                int personPCN = Convert.ToInt32(personInfo[0]);

                foreach (Person person in personManager.GetListOfPeople())
                {
                    if (personManager.GetPersonPCN(person) == personPCN)
                    {
                        editPersonInformation = new EditPersonInformation();
                        editPersonInformation.SetPerson(personManager, person, workshopManager);
                        editPersonInformation.ShowDialog();
                    }
                }
                UpdateListOfWorkshops();
                UpdateListOfAllPeople();
                UpdateTeacherComboBox();
                ClearTextBoxesWorkshop();
                UpdateInBuildingWorkshops();
                UpdateOnlineWorkshops();
            }
            catch (NullOrEmptyInputException m)
            {
                MessageBox.Show(m.Message + "Select a person from the listbox");
            }

        }

        private void btnRemovePerson_Click(object sender, EventArgs e)
        {
            int currentPCN = 0;
            try
            {
                if (lbAllPeople.SelectedIndex == -1)
                {
                    throw new NullOrEmptyInputException();
                }
                string[] personInfo = lbAllPeople.SelectedItem.ToString().Split(' ');
                int personPCN = Convert.ToInt32(personInfo[0]);
                foreach (Person person in personManager.GetListOfPeople())
                {
                    if (personManager.GetPersonPCN(person) == personPCN)
                    {
                        currentPCN = currentPCN = personManager.GetPersonPCN(person);
                        if (workshopManager.CheckWorkshopTeacherInfo(currentPCN))
                        {
                            workshopManager.RemoveWorkshop(workshopManager.FindWorkshopByTeacher(currentPCN)); //
                            throw new PersonNotFoundException();
                        }
                        personManager.RemovePerson(personManager.GetPersonPCN(person));
                        break;
                    }
                }
                UpdateListOfWorkshops();
                UpdateListOfAllPeople();
            }
            catch (PersonNotFoundException m)
            {
                MessageBox.Show("This person was assigned to teach a workshop. By changing his/her position the workshop will be deleted. \r\n" + m.Message);
            }
            catch (NullOrEmptyInputException m)
            {
                MessageBox.Show(m.Message + "Select a person from the listbox");
            }
            catch (WorkshopNotFoundException m)
            {
                MessageBox.Show(m.Message);
            }
        }
        public void ClearTextboxesPerson()
        {
            txbNames.Text = String.Empty;
            txbPCN.Text = String.Empty;
            cbbTypeOfPerson.SelectedIndex = -1;
        }
        //----------------------------RegisterWorkshop


        private void btnRegisterWorkshop_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txbTitle.Text.ToString()) || String.IsNullOrEmpty(rtxbDescription.Text.ToString()) || cbbTeachers.SelectedIndex == -1
                    || String.IsNullOrEmpty(txbCapacity.Text.ToString()) || cbbPlaceOfWorkshop.SelectedIndex == -1)
                {
                    throw new NullOrEmptyInputException();
                }
                string[] teacher = cbbTeachers.SelectedItem.ToString().Split(' ');
                int teacherPCN = Convert.ToInt32(teacher[teacher.Length - 1]);
                if (cbbPlaceOfWorkshop.SelectedIndex == 1)
                {
                    if (String.IsNullOrEmpty(txbAddress.Text.ToString()) || String.IsNullOrEmpty(txbRoomNumber.Text.ToString()))
                    {
                        throw new NullOrEmptyInputException();
                    }
                    string address = txbAddress.Text.ToString();
                    string roomNumber = txbRoomNumber.Text.ToString();
                    workshopManager.CreateInBuildingWorkshop(txbTitle.Text.ToString(), rtxbDescription.Text.ToString(), Convert.ToInt32(txbCapacity.Text),
                        personManager.FindPerson(teacherPCN), address, roomNumber);
                }
                else if (cbbPlaceOfWorkshop.SelectedIndex == 0)
                {
                    workshopManager.CreateOnlineWorkshop(txbTitle.Text.ToString(), rtxbDescription.Text.ToString(), Convert.ToInt32(txbCapacity.Text),
                        personManager.FindPerson(teacherPCN));
                }
                UpdateListOfWorkshops();
                ClearTextBoxesWorkshop();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input.");
            }
            catch (NullOrEmptyInputException m)
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
            catch (OverflowException)
            {
                MessageBox.Show("The maximum capacity input is out of boundaries.");
            }
        }
        public void ClearTextBoxesWorkshop()
        {
            txbTitle.Text = String.Empty;
            rtxbDescription.Text = String.Empty;
            txbAddress.Text = String.Empty;
            txbRoomNumber.Text = String.Empty;
            cbbTeachers.SelectedIndex = -1;
            cbbTeachers.SelectedItem = String.Empty;
            txbCapacity.Text = String.Empty;
        }

        public void UpdateTeacherComboBox()
        {
            cbbTeachers.Items.Clear();
            foreach (Person teacher in personManager.GetListOfPeople())
            {
                if (personManager.GetTypeOfPerson(teacher) == TypeOfPerson.Teacher)
                {
                    cbbTeachers.Items.Add($"{personManager.GetPersonNames(teacher)}, {personManager.GetPersonPCN(teacher)}");
                }
            }
        }
        private void cbbPlaceOfWorkshop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbPlaceOfWorkshop.SelectedIndex == 1)
            {
                txbAddress.Visible = true;
                txbRoomNumber.Visible = true;
                lblAddress.Visible = true;
                lblRoomNumber.Visible = true;
            }
            else
            {
                txbAddress.Visible = false;
                txbRoomNumber.Visible = false;
                lblAddress.Visible = false;
                lblRoomNumber.Visible = false;
            }
        }

        public void UpdateOnlineWorkshops()
        {

            lbxShowAllWorkshops.Items.Clear();
            lbxViewWorkshops.Items.Clear();
            lbxStartWorkshop.Items.Clear();

            foreach (Workshop workshop in workshopManager.GetAvailableWorkshops())
            {
                if (workshop.GetType() == typeof(Online))
                {
                    lbxViewWorkshops.Items.Add(workshopManager.GetWorkshopInfo(workshop));
                    lbxShowAllWorkshops.Items.Add(workshopManager.GetWorkshopInfo(workshop));
                    lbxStartWorkshop.Items.Add(workshopManager.GetWorkshopInfo(workshop));
                }
            }
            lblChooseStudent.Visible = false;
            gbxAllStudents.Visible = false;
            gbxShowCertainWorkshopInfo.Visible = false;
        }

        public void UpdateInBuildingWorkshops()
        {
            lbxViewWorkshops.Items.Clear();
            lbxShowAllWorkshops.Items.Clear();
            lbxStartWorkshop.Items.Clear();

            foreach (Workshop workshop in workshopManager.GetAvailableWorkshops())
            {
                if (workshop.GetType() == typeof(InBuilding))
                {
                    lbxViewWorkshops.Items.Add(workshopManager.GetWorkshopInfo(workshop));
                    lbxShowAllWorkshops.Items.Add(workshopManager.GetWorkshopInfo(workshop));
                    lbxStartWorkshop.Items.Add(workshopManager.GetWorkshopInfo(workshop));
                }
            }
            lblChooseStudent.Visible = false;
            gbxAllStudents.Visible = false;
            gbxShowCertainWorkshopInfo.Visible = false;
        }
        public void UpdateListOfWorkshops()
        {
            lbxViewWorkshops.Items.Clear();
            lbxShowAllWorkshops.Items.Clear();
            lbxStartWorkshop.Items.Clear();

            foreach (Workshop workshop in workshopManager.GetAvailableWorkshops())
            {
                lbxViewWorkshops.Items.Add(workshopManager.GetWorkshopInfo(workshop));
                lbxShowAllWorkshops.Items.Add(workshopManager.GetWorkshopInfo(workshop));
                lbxStartWorkshop.Items.Add(workshopManager.GetWorkshopInfo(workshop));
            }
            lblChooseStudent.Visible = false;
            gbxAllStudents.Visible = false;
            gbxShowCertainWorkshopInfo.Visible = false;

        }
        private void btnOnline_Click(object sender, EventArgs e)
        {
            this.UpdateOnlineWorkshops();
        }

        private void btnInBuilding_Click(object sender, EventArgs e)
        {
            this.UpdateInBuildingWorkshops();
        }

        private void btnAllWorkshops_Click(object sender, EventArgs e)
        {
            this.UpdateListOfWorkshops();
        }

        private void btnEditWorkshop_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbxViewWorkshops.SelectedIndex == -1)
                {
                    throw new NullOrEmptyInputException();
                }
                string[] workshopInfo = lbxViewWorkshops.SelectedItem.ToString().Split(' ');
                int workshopID = Convert.ToInt32(workshopInfo[0]);

                editWorkshopInformation = new EditWorkshopInformation();
                editWorkshopInformation.SetWorkshop(workshopManager.FindWorkshopByID(workshopID), personManager, workshopManager);
                editWorkshopInformation.ShowDialog();
                this.UpdateListOfWorkshops();
            }
            catch (NullOrEmptyInputException m)
            {
                MessageBox.Show(m.Message + "Select a workshop from the listbox");
            }

        }

        private void btnRemoveWorkshop_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbxViewWorkshops.SelectedIndex == -1)
                {
                    throw new NullOrEmptyInputException();
                }
                string[] workshopInfo = lbxViewWorkshops.SelectedItem.ToString().Split(' ');
                int workshopID = Convert.ToInt32(workshopInfo[0]);

                workshopManager.RemoveWorkshop(workshopManager.FindWorkshopByID(workshopID));
                this.UpdateListOfWorkshops();
            }
            catch (NullOrEmptyInputException m)
            {
                MessageBox.Show(m.Message + "Select a workshop from the listbox");
            }
            catch (WorkshopNotFoundException m)
            {
                MessageBox.Show(m.Message);
            }
        }

        //--------------------------------------------------Enroll students for a workshop

        private void btnShowOnlineWorkshops_Click(object sender, EventArgs e)
        {
            this.UpdateOnlineWorkshops();
        }

        private void btnShowInBuildingWokrshops_Click(object sender, EventArgs e)
        {
            this.UpdateInBuildingWorkshops();
        }

        private void btnShowAllWorkshops_Click(object sender, EventArgs e)
        {
            this.UpdateListOfWorkshops();
        }

        private void btnEnrollPeopleToWorkshop_Click(object sender, EventArgs e)
        {

            try
            {
                if (lbxShowAllWorkshops.SelectedIndex == -1)
                {
                    throw new NullOrEmptyInputException();
                }
                lblChooseStudent.Visible = true;
                gbxAllStudents.Visible = true;
                gbxShowCertainWorkshopInfo.Visible = true;

                string[] workshopInfo = lbxShowAllWorkshops.SelectedItem.ToString().Split(' ');
                int workshopID = Convert.ToInt32(workshopInfo[0]);

                lblChosenWorkshopTitle.Text = $"{workshopManager.GetWorkshopTitle(workshopManager.FindWorkshopByID(workshopID))}";
                lblChosenWorkshop.Text = $"Teacher: {personManager.GetPersonNames(workshopManager.GetWorkshopTeacher(workshopManager.FindWorkshopByID(workshopID)))}";
                if (workshopManager.FindWorkshopByID(workshopID).GetType() == typeof(InBuilding))
                {
                    lblAddressUrl.Text = $"Address: {((InBuilding)workshopManager.FindWorkshopByID(workshopID)).GetAddress} room N: {((InBuilding)workshopManager.FindWorkshopByID(workshopID)).GetRoomNumber}";
                }
                else
                {
                    lblAddressUrl.Text = $"Address: {((Online)workshopManager.FindWorkshopByID(workshopID)).GetUrl}";
                }
                UpdateListOfEnrolledStudents(workshopManager.FindWorkshopByID(workshopID));
            }
            catch (NullOrEmptyInputException m)
            {
                MessageBox.Show(m.Message + "Select a workshop from the listbox");
            }

        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbxShowStudents.SelectedIndex == -1 || lbxShowAllWorkshops.SelectedIndex == -1)
                {
                    throw new NullOrEmptyInputException();
                }
                string[] workshopInfo = lbxShowAllWorkshops.SelectedItem.ToString().Split(' ');
                int workshopID = Convert.ToInt32(workshopInfo[0]);
                string[] studentInfo = lbxShowStudents.SelectedItem.ToString().Split(' ');
                int studentPCN = Convert.ToInt32(studentInfo[0]);

                workshopManager.EnrollForWorkshop(personManager.FindPerson(studentPCN), workshopManager.FindWorkshopByID(workshopID));
                this.UpdateListOfEnrolledStudents(workshopManager.FindWorkshopByID(workshopID));
            }
            catch (NullOrEmptyInputException m)
            {
                MessageBox.Show(m.Message);
            }
            catch (ExistingPersonException m)
            {
                MessageBox.Show(m.Message);
            }
            catch (PersonNotFoundException m)
            {
                MessageBox.Show(m.Message);
            }
            catch (WorkshopCapacityReachedException m)
            {
                MessageBox.Show(m.Message + "Select a workshop/person from the listbox.");
            }
        }

        public void UpdateListOfEnrolledStudents(Workshop workshop)
        {
            lbxShowStudents.Items.Clear();
            lbxEnrolledStudents.Items.Clear();
            foreach (Person student in workshopManager.ListOfEnrolledStudents(workshop))
            {
                lbxEnrolledStudents.Items.Add($"{personManager.GetStudentLoginSeatNumber(workshop, student)}");
            }
            foreach (Person student in personManager.GetListOfAllPeople(TypeOfPerson.Student))
            {
                lbxShowStudents.Items.Add(personManager.GetPersonInfo(student));
            }
        }

        private void lbxShowAllWorkshops_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblChooseStudent.Visible = false;
            gbxAllStudents.Visible = false;
            gbxShowCertainWorkshopInfo.Visible = false;
        }

        private void btnRemovePersonFromWorkshop_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbxEnrolledStudents.SelectedIndex == -1 || lbxShowAllWorkshops.SelectedIndex == -1)
                {
                    throw new NullOrEmptyInputException();
                }
                string[] workshopInfo = lbxShowAllWorkshops.SelectedItem.ToString().Split(' ');
                int workshopID = Convert.ToInt32(workshopInfo[0]);
                string[] studentInfo = lbxEnrolledStudents.SelectedItem.ToString().Split(' ');
                int studentPCN = Convert.ToInt32(studentInfo[0]);

                if (workshopManager.ListOfEnrolledStudents(workshopManager.FindWorkshopByID(workshopID)).Contains(personManager.FindPerson(studentPCN)))
                {
                    workshopManager.RemoveStudentFromWorkshop(workshopManager.FindWorkshopByID(workshopID), personManager.FindPerson(studentPCN));
                    UpdateListOfEnrolledStudents(workshopManager.FindWorkshopByID(workshopID));
                }
            }
            catch (NullOrEmptyInputException m)
            {
                MessageBox.Show(m.Message + "Select a student from the listbox");
            }
            catch (PersonNotFoundException m)
            {
                MessageBox.Show(m.Message);
            }
        }

        //----------------------------------------Start a workshop

        private void button4_Click(object sender, EventArgs e)
        {
            this.UpdateOnlineWorkshops();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.UpdateInBuildingWorkshops();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.UpdateListOfWorkshops();
        }

        private void btnStartWorkshop_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbxStartWorkshop.SelectedIndex == -1)
                {
                    throw new NullOrEmptyInputException();
                }
                string[] workshopInfo = lbxStartWorkshop.SelectedItem.ToString().Split(' ');
                int workshopID = Convert.ToInt32(workshopInfo[0]);

                workshopManager.StartWorkshop(workshopManager.FindWorkshopByID(workshopID));
                lbxActiveWorkshops.Items.Add(workshopManager.GetWorkshopInfo(workshopManager.FindWorkshopByID(workshopID)));
                this.UpdateOnlineWorkshops();
                this.UpdateInBuildingWorkshops();
                this.UpdateListOfWorkshops();
            }
            catch (NullOrEmptyInputException m)
            {
                MessageBox.Show(m.Message + "Select a workshop from the listbox.");
            }

        }

        private void btnEndWorkshop_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbxActiveWorkshops.SelectedIndex == -1)
                {
                    throw new NullOrEmptyInputException();
                }
                string[] workshopInfo = lbxActiveWorkshops.SelectedItem.ToString().Split(' ');
                int workshopID = Convert.ToInt32(workshopInfo[0]);

                workshopManager.EndWorkshop(workshopManager.FindWorkshopByID(workshopID));
                lbxPassedWorkshops.Items.Add(workshopManager.GetWorkshopInfo(workshopManager.FindWorkshopByID(workshopID)));
                lbxActiveWorkshops.Items.Remove(workshopManager.GetWorkshopInfo(workshopManager.FindWorkshopByID(workshopID)));
                this.UpdateOnlineWorkshops();
                this.UpdateInBuildingWorkshops();
                this.UpdateListOfWorkshops();
            }
            catch (NullOrEmptyInputException m)
            {
                MessageBox.Show(m.Message + "Select a workshop from the listbox.");
            }
            catch (WorkshopNotFoundException m)
            {
                MessageBox.Show(m.Message);
            }
        }

        //------------------------------------Save workshop information
        private void btnSaveInformation_Click(object sender, EventArgs e)
        {
            string filename;
            SaveFileDialog sfd = new SaveFileDialog();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                filename = sfd.FileName;
                workshopManager.SaveInformationToTextFile(filename);
            }
            else { MessageBox.Show("You chose CANCEL"); }
        }
    }
}
