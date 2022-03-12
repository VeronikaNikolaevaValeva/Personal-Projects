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
    public partial class ComplaintsStudent : UserControl
    {
        public Student student;
        public ComplaintsStudent()
        {
            InitializeComponent();
        }

        public void SetStudent(Student student)
        {
            this.student = student;
        }

        private void btnUploadComplaint_Click(object sender, EventArgs e)
        {
            
            string newComplaint = txtBFillComplaint.Text.ToString();
            if(chBAnonymous.Checked)
            {
                lbFillComplaints.Items.Add($"--> {newComplaint}");
                lbViewComplaints.Items.Add($"--> {newComplaint}");
            }
            else if(!chBAnonymous.Checked)
            {
                lbFillComplaints.Items.Add($"--> {newComplaint} - {student.GetName()}");
                lbViewComplaints.Items.Add($"--> {newComplaint} - {student.GetName()}");
            }
        }
    }
}
