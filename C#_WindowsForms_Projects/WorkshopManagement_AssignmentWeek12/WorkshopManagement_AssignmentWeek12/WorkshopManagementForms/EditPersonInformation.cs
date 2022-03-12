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
    public partial class EditPersonInformation : Form
    {
        PersonManager personManager;
        Person person;
        WorkshopManager workshopManager;
        int currentPCN = 0;
        public EditPersonInformation()
        {
            InitializeComponent();
        }

        public void SetPerson(PersonManager pm, Person p, WorkshopManager w)
        {
            this.person = p;
            this.personManager = pm;
            workshopManager = w;
            currentPCN = personManager.GetPersonPCN(person);
            DeterminePersonInfo();
        }

        public void DeterminePersonInfo()
        {
            txbChangeName.Text = personManager.GetPersonNames(person);
            txbChangePCN.Text = personManager.GetPersonPCN(person).ToString();
            cbbChengeTypeOfPerson.SelectedItem = (TypeOfPerson)(personManager.GetTypeOfPerson(person));
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txbChangeName.Text) || String.IsNullOrEmpty(txbChangePCN.Text) || cbbChengeTypeOfPerson.SelectedIndex == -1)
                {
                    throw new NullOrEmptyInputException();
                }
                int newPCN = Convert.ToInt32(txbChangePCN.Text.ToString());
                string names = txbChangeName.Text.ToString();
                personManager.EditPersonInfo(currentPCN, newPCN, names, (TypeOfPerson)(cbbChengeTypeOfPerson.SelectedIndex));
                MessageBox.Show("Information changed.");
                if (workshopManager.CheckWorkshopTeacherInfo(currentPCN) && cbbChengeTypeOfPerson.SelectedIndex == 0)
                {
                    throw new PersonNotFoundException();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input for the PCN.");
            }
            catch (NullOrEmptyInputException)
            {
                MessageBox.Show("Invalid input.");
            }
            catch (ExistingPersonException m)
            {
                MessageBox.Show("This pcn is already used.");
            }
            catch (WorkshopNotFoundException m)
            {
                MessageBox.Show(m.Message);
            }
            catch (PersonNotFoundException m)
            {
                MessageBox.Show("This person was assigned to teach a workshop. By changing his/her position the workshop will be deleted. \r\n" + m.Message);
                workshopManager.RemoveWorkshop(workshopManager.FindWorkshopByTeacher(currentPCN));
            }
            finally
            {
                this.Hide();
            }
        }
    }
}
