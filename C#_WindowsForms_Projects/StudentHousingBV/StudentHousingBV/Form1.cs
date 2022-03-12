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
    public partial class LogInPage : Form
    { 
        List<string> StFirstNames = new List<string>(){ "Alex", "Charlie", "Carter", "Morgan", "Taylor", "Blake", "Brooke", "Sky", "Dallas", "Dakota" };
        List<string> StLastNames = new List<string>() { "Smith", "Jones", "Johnson", "Williams", "Brown", "Davis", "Miller", "Wilson", "Young", "Coleman" };
        int[] StAge = new int[4] { 18, 19, 20, 21 };
        string[] UserSex = new string[2] { "female", "male" };
        List<int> StNumber = new List<int>() { 1256, 1408, 8967, 1583, 4506, 6964, 3158, 7543, 2486, 2990 };
        List<int> StRoomNumber = new List<int>() { 101, 102, 103, 104, 105, 201, 202, 203, 204, 205 };
        List<int> StBankAccount = new List<int>() { 38289, 12478, 16904, 45963, 75963, 60450, 35902, 75930, 15830, 65803 };
        List<double> StInitialBalance = new List<double>() { 100, 110, 120, 130, 140, 150, 160, 170, 180, 190 };
        Random random = new Random();
        string[] EmployeeFirstNames = new string[5] { "Cameron", "Ezra", "River", "Milan", "Bailey" };
        string[] EmployeeLastNames = new string[5] { "Sanhez", "Morris", "Moore", "Adams", "Anderson" };
        int[] employeeAge = new int[5] { 24, 28, 32, 36, 26 };
        int[] employeeNumber = new int[5] { 1, 2, 3, 4, 5 };
        string[] employeeEmails = new string[5] { "cameron.sanchez@SHousingBV.nl", "ezra.morris.SHousingBV.nl", "river.moore@SHousingBV.nl", "milan.adams@SHousingBV.nl", "bailey.anderson@SHosuingBV.nl" };

        List<Employee> ListOfAllEmployees;
        List<Student> ListOfAllStudents;
        int SelectedIndex;
        public LogInPage()
        {
            InitializeComponent();
            
        }

        private void rBEmployee_CheckedChanged(object sender, EventArgs e)
        {
            ListOfAllEmployees = new List<Employee>();
            cbbProfiles.Items.Clear();
            for (int i = 0; i < 5; i++)
            {
                Employee employee = CreateEmployeeByIndex(i);
                cbbProfiles.Items.Add(employee.GetEmployeeInfo());
                ListOfAllEmployees.Add(employee);
            }
        }

        private void rBStudents_CheckedChanged(object sender, EventArgs e)
        {
            ListOfAllStudents = new List<Student>();
            cbbProfiles.Items.Clear();
            for (int i = 0; i < 10; i++)
            {
                Student student = CreateStudentByIndex(i);
                cbbProfiles.Items.Add(student.GetStudentInfo());
                ListOfAllStudents.Add(student);
            }
        }

        private Student CreateStudentByIndex(int index)
        {
            string sex = UserSex[random.Next(0, 1)];
            int age = StAge[random.Next(0, 3)];
            return new Student(
                StFirstNames[index],
                StLastNames[index],
                age,
                sex,
                StNumber[index],
                StRoomNumber[index],
                StBankAccount[index],
                StInitialBalance[index]
                );
        }
        private Employee CreateEmployeeByIndex(int index)
        {
            string sex = UserSex[random.Next(0, 1)];
            return new Employee(
                EmployeeFirstNames[index],
                EmployeeLastNames[index],
                employeeAge[index],
                sex,
                employeeNumber[index],
                employeeEmails[index]
                );
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            SelectedIndex = cbbProfiles.SelectedIndex;
            if (rBStudents.Checked)
            {
                Student_App student_app = new Student_App(ListOfAllStudents[SelectedIndex]);
                student_app.Show();
                this.Hide();
            }
            else if (rBEmployee.Checked)
            {
                Employee_App employee_app = new Employee_App(ListOfAllEmployees[SelectedIndex], ListOfAllStudents);
                employee_app.Show();
                this.Hide();
            }
        }

        public List<Student> GetListOfAllStudents()
        {
            return ListOfAllStudents;
        }
        
     
       
    }
}
