using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHousingBV
{
    public partial class Employee_App : Form
    {
        private Employee employee;
        public Employee_App(Employee employee, List<Student> listOfStudents)
        {
            InitializeComponent();
            this.employee = employee;
            pnlEmployeeAccount.BringToFront();
            pnlmanageAccountsEmployee.SetListOfAllStudents(listOfStudents);
        }

        private void Employee_App_Load(object sender, EventArgs e)
        {
            lblName.Text += $"{employee.GetName()}";
            lblAge.Text += $"{employee.GetAge()}";
            lblSex.Text += $"{employee.GetSex()}";
            lblEmployeeNumber.Text += $"{employee.GetEmployeeNumber()}";
            if (employee.GetSex() == "male")
            {
                profilePicture.Image = Properties.Resources.man_avatar;
            }
            else
            {
                profilePicture.Image = Properties.Resources.woman_avatar;
            }
            HideUserControls();
            pnlAnnouncementsEmployee.SetEmployee(employee);
        }

        private FolderBrowserDialog d;
        private void btnDownloadContract_Click(object sender, EventArgs e)
        {
            d = new System.Windows.Forms.FolderBrowserDialog();
            DialogResult result=d.ShowDialog();
            string folderName;
            if (result == DialogResult.OK)
            {
                folderName = d.SelectedPath;
                WebClient Client = new WebClient();
                Client.DownloadFile("https://inewicdn.azureedge.net/files/Employment_Agreement.pdf", $@"{folderName}\contract.pdf");
                lblDownloadResult.Text = "Download completed! Check your Downloads folder!";
            }
            
        }

        private void btnHouseRulesEmp_Click(object sender, EventArgs e)
        {
            pnlHouseRulesEmployee.Visible = true;
            pnlHouseRulesEmployee.BringToFront();
            ChangeAllColors();
            btnHouseRulesEmp.BackColor = Color.LightSteelBlue;
        }
        private void ChangeAllColors()
        {
            btnHouseRulesEmp.BackColor = Color.AliceBlue;
            btnAnnouncementsEmp.BackColor = Color.AliceBlue;
            btnComplaintsEmp.BackColor = Color.AliceBlue;
            btnContactPageEmp.BackColor = Color.AliceBlue;
            btnMyAccountEmp.BackColor = Color.AliceBlue;
            btnManageAccountsEmp.BackColor = Color.AliceBlue;
        }
        // every time a new panel is added, add it here and make its visability false
        private void HideUserControls()
        {
            pnlHouseRulesEmployee.Visible = false;
            pnlComplaintsEmployee.Visible = false;
            pnlAnnouncementsEmployee.Visible = false;
            pnlCommonQuestionsEmployee.Visible = false;
            pnlmanageAccountsEmployee.Visible = false;
        }
        private void btnMyAccountEmp_Click(object sender, EventArgs e)
        {
            HideUserControls();
            ChangeAllColors();
            btnMyAccountEmp.BackColor = Color.LightSteelBlue;
        }

        
        private void btnAnnouncementsEmp_Click(object sender, EventArgs e)
        {
            pnlAnnouncementsEmployee.Visible = true;
            pnlAnnouncementsEmployee.BringToFront();
            ChangeAllColors();
            btnAnnouncementsEmp.BackColor = Color.LightSteelBlue;
        }

        private void btnComplaintsEmp_Click(object sender, EventArgs e)
        {
            pnlComplaintsEmployee.Visible = true;
            pnlComplaintsEmployee.BringToFront();
            ChangeAllColors();
            btnComplaintsEmp.BackColor = Color.LightSteelBlue;
        }

        private void btnContactPageEmp_Click(object sender, EventArgs e)
        {
            ChangeAllColors();
            btnContactPageEmp.BackColor = Color.LightSteelBlue;
        }

        private void btnCommonQuestionsEmp_Click(object sender, EventArgs e)
        {
            pnlCommonQuestionsEmployee.Visible = true;
            pnlCommonQuestionsEmployee.BringToFront();
            ChangeAllColors();
            btnCommonQuestionsEmp.BackColor = Color.LightSteelBlue;
        }

        private void btnLogOutEmp_Click(object sender, EventArgs e)
        {
            LogInPage login = new LogInPage();
            login.Show();
            this.Hide();
        }

        private void commonQuestionsEmployee1_Load(object sender, EventArgs e)
        {

        }

        private void btnManageAccountsEmp_Click_1(object sender, EventArgs e)
        {
            pnlmanageAccountsEmployee.Visible = true;
            pnlmanageAccountsEmployee.BringToFront();
            ChangeAllColors();
            btnManageAccountsEmp.BackColor = Color.LightSteelBlue;
        }
    }
}
