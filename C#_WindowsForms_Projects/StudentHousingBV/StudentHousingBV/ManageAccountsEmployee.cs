using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHousingBV
{
    public partial class ManageAccountsEmployee : UserControl
    {
        public List<Student> ListOfStudents ;
        public ManageAccountsEmployee()
        {
            InitializeComponent();
        }

        public void SetListOfAllStudents(List<Student> listOfstudents)
        {
            this.ListOfStudents = listOfstudents;
        }
        private void btnAccountInfo_Click(object sender, EventArgs e)
        {
            int index = lsbAllStudents.SelectedIndex;
            foreach(Student student in ListOfStudents)
            {
                if(student == ListOfStudents[index])
                {
                    txtbAccountInfo.Text = student.GetStudentInfo();
                }
            }

        }

        private void btnShowAllStudents_Click(object sender, EventArgs e)
        {
            foreach (Student student in ListOfStudents)
            {
                lsbAllStudents.Items.Add(student.GetName());
            }
        }
    }
}
