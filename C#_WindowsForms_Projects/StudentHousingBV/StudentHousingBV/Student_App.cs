using System;
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
    public partial class Student_App : Form
    {
        public Student student;
        Random rnd = new Random();
        public Student_App(Student student)
        {
            InitializeComponent();
            this.student = student;
        }


        private void Student_App_Load(object sender, EventArgs e)
        {
            pnlMyAccount.BringToFront();
            int building = rnd.Next(1, 10);
            lblName.Text += $"{student.GetName()}";
            lblAge.Text += $"{student.GetAge()}";
            lblSex.Text += $"{student.GetSex()}";
            lblStudentNumber.Text += $"{student.GetStudentNumber()}";
            lblUniversity.Text += "Fontys UAS";
            lblBuilding.Text += $"{building}";
            lblRoomNumber.Text += $"{student.GetRoomNumber()}";
            if (student.GetSex() == "female")
            {
                profilePicture.Image = Properties.Resources.woman_avatar;
            }
            else
            {
                profilePicture.Image = Properties.Resources.man_avatar;
            }
            HideUserControls();
            SetStudentToUserControls();
            timerTaskReminder.Enabled = true;
            timerTaskReminder.Start();
        }

        private void SetStudentToUserControls()
        {
            complaintsStudent.SetStudent(student);
            pnlAnnouncements.SetStudent(student);
            pnlWallet.SetStudent(student);
            pnlCommonQuestions.SetStudent(student);
            pnl_tasks_student.SetStudent(student);
        }
        private void btnAnnouncements_Click(object sender, EventArgs e)
        {
            pnlAnnouncements.Show();
            pnlAnnouncements.BringToFront();
            ChangeAllColors();
            btnAnnouncements.BackColor = Color.LightSteelBlue;
        }


        private void btnContactPage_Click(object sender, EventArgs e)
        {
            ChangeAllColors();
            btnContactPage.BackColor = Color.LightSteelBlue;


        }
        private void btnWallet_Click(object sender, EventArgs e)
        {

            pnlWallet.Show();
            pnlWallet.BringToFront();
            ChangeAllColors();
            btnWallet.BackColor = Color.LightSteelBlue;

        }


        private void btnMyTasks_Click(object sender, EventArgs e)
        {
            pnl_tasks_student.Show();
            pnl_tasks_student.BringToFront();
            ChangeAllColors();
            btnMyTasks.BackColor = Color.LightSteelBlue;
        }

        private void btnCommonQuestions_Click(object sender, EventArgs e)
        {
            ChangeAllColors();
            btnCommonQuestions.BackColor = Color.LightSteelBlue;
            pnlCommonQuestions.Show();
            pnlCommonQuestions.BringToFront();

        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogInPage login = new LogInPage();
            login.Show();
            this.Hide();
            timerTaskReminder.Stop();
        }

        private void btnHouseRules_Click(object sender, EventArgs e)
        {
            pnlHouseRules.Visible = true;
            pnlHouseRules.BringToFront();
            ChangeAllColors();
            btnHouseRules.BackColor = Color.LightSteelBlue;

        }
        private void ChangeAllColors()
        {
            btnHouseRules.BackColor = Color.AliceBlue;
            btnAnnouncements.BackColor = Color.AliceBlue;
            btnComplaints.BackColor = Color.AliceBlue;
            btnContactPage.BackColor = Color.AliceBlue;
            btnMyAccount.BackColor = Color.AliceBlue;
            btnWallet.BackColor = Color.AliceBlue;
            btnMyTasks.BackColor = Color.AliceBlue;
            btnCommonQuestions.BackColor = Color.AliceBlue;
        }
        private void HideUserControls()
        {
            pnlHouseRules.Visible = false;
            complaintsStudent.Visible = false;
            pnlWallet.Visible = false;
            pnlCommonQuestions.Visible = false;
            pnl_tasks_student.Visible = false;
            pnlAnnouncements.Visible = false;
        }

        private void btnMyAccount_Click(object sender, EventArgs e)
        {
            HideUserControls();
            ChangeAllColors();
            btnMyAccount.BackColor = Color.LightSteelBlue;


        }

        private void btnComplaints_Click(object sender, EventArgs e)
        {
            complaintsStudent.Visible = true;
            complaintsStudent.BringToFront();
            ChangeAllColors();
            btnComplaints.BackColor = Color.LightSteelBlue;
        }

        private void timerTaskReminder_Tick(object sender, EventArgs e)
        {
            if (pnl_tasks_student.areThereUndoneTasks())
            {
                MessageBox.Show($"You still haven't done your chores!");
            }
            timerTaskReminder.Stop();
            
        }

        private void pnlAnnouncements_Load(object sender, EventArgs e)
        {

        }

        private void pnlAnnouncements_Load_1(object sender, EventArgs e)
        {

        }
    }
}