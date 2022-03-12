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
    public partial class CommonQuestionsEmployee : UserControl
    {
        public CommonQuestionsEmployee()
        {
            InitializeComponent();
        }

        private void btnRemoveCommonQuestion_Click(object sender, EventArgs e)
        {
            string RemoveSelectedQuestion = lsbEditCommonQuestions.SelectedItem.ToString();
            lsbEditCommonQuestions.Items.Remove(RemoveSelectedQuestion);
            lsbCommonQuestionsView.Items.Remove(RemoveSelectedQuestion);
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            string NewQuestion = txtbAddQuestion.Text.ToString();
            lsbEditCommonQuestions.Items.Add(NewQuestion);
            lsbCommonQuestionsView.Items.Add(NewQuestion);
        }
    }
}
