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
    public partial class CommonQuestions : UserControl
    {
        public Student student;
        string[] QuestionAnswears;
        public CommonQuestions()
        {
            InitializeComponent();
        }
        public void SetStudent(Student student)
        {
            this.student = student;
            QuestionAnswears = new string[4] {$"Your student number is {student.GetStudentNumber()}",
                $"Your bank account number is: {student.GetBankAccount()}", $"Your room number is {student.GetRoomNumber()}",
                "You can always e-mail one of our employees! Their e-mails are: cameron.sanchez@SHousingBV.nl, " +
                "ezra.morris.SHousingBV.nl, river.moore@SHousingBV.nl, milan.adams@SHousingBV.nl, " +
                "bailey.anderson@SHosuingBV.nl"};
        }

        private void ContactPageStudents_Load(object sender, EventArgs e)
        {

        }

        private void cBPersonalQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            int QuestionIndex = cBPersonalQuestions.SelectedIndex;
            rtxtbAnswears.Text = QuestionAnswears[QuestionIndex];

        }
    }
}
