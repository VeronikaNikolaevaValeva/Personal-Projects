using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAboutPizzas
{
    public partial class FormMain : Form
    {
        private StudentAssociation sa;
        public FormMain()
        {
            InitializeComponent();
            this.sa = new StudentAssociation("Proxy");
            this.AddSomeStudents();
            this.AddPizzaTypesToCombobox();
            this.Text = "app made by Veronika Valeva";
        }

        private void AddSomeStudents()
        {//adds 7 students to the student association
            string[] names = { "Arnold", "Bert", "Carla", "Domino", "Egly", "Felix", "Gerald" };
            int id = 111111;
           foreach (var name in names)
            {
                this.sa.AddStudent(id, name);
                id = id + 111111;
            }
        }

        private void AddPizzaTypesToCombobox()
        {  //todo add the pizzatypes one by one to the combobox cbKindOfPizza
            for(int i = 0; i < 6; i++)
            {
                cbKindOfPizza.Items.Add((KindOfPizza)(i));
            }
        }

        private void btnShowAllPizzas_Click(object sender, EventArgs e)
        {
            Pizza[] ListOfAllPizzas = sa.ShowAllPizzas();
            lbInfo.Items.Clear();
            foreach (Pizza p in ListOfAllPizzas)
            {
                lbInfo.Items.Add(p.GetInfo());
            }
        }

        private void showStudents_Click(object sender, EventArgs e)
        {
            Student[] ListOfAllStudents = sa.ShowAllStudents();
            lbInfo.Items.Clear();
            foreach (Student s in ListOfAllStudents)
            {
                lbInfo.Items.Add(s.GetInfo());
            }
        }

        private void btnRegisterChosenPizza_Click(object sender, EventArgs e)
        {
            int StudentNum = int.Parse(tbStudentnumber.Text);
            int indexOfPizza = cbKindOfPizza.SelectedIndex;
            KindOfPizza Kind = (KindOfPizza)(indexOfPizza);
            bool Result = sa.RegisterStudentsChoice(StudentNum, Kind);
            if(Result)
            {
                MessageBox.Show("Your choice was registered!");
            }
        }

        private void btnShowPizzaForStudent_Click(object sender, EventArgs e)
        {
            int StudentNum = int.Parse(tbStudentnumber.Text);
            Student student = sa.GetStudent(StudentNum);
            if (student != null && student.StudentsPizza() == true)
            {
                FormExtra formExtra = new FormExtra(student, student.GetStudentsPizza); ;
                formExtra.Show();
            }

        }
    }
}
