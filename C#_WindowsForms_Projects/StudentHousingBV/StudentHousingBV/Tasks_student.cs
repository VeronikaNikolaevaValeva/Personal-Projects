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
    public partial class Tasks_student : UserControl
    {
        public Student student;
        public double balance;
        private int counter=0;
        public void SetStudent(Student student)
        {
            this.student = student;
        }
        private double GetBalance()
        {
            return this.student.GetInitialBalance();
        }
        public Tasks_student()
        {
            InitializeComponent();
        }
        private bool CheckIfSelected()
        {
            if (lbxUndoneTasks.SelectedIndex > -1)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please select a task!");
                return false;
            }
        }
        public bool areThereUndoneTasks()
        {
            if (lbxUndoneTasks.Items.Count == 0)
            {
                return false;
            }
            return true;
        }
        private bool IsPay(double amount)
        {
            if (balance - amount >= 0)
            {

                return true;
            }
            else
            {
                return false;

            }
        }
        private void Pay(double amount)
        {
            balance -= amount;
            student.SetBalance(balance);
            pnlDeposit.Visible = false;
        }
        private void Deposit(double amount)
        {
            tbAmount.Clear();
            MessageBox.Show("You don't have enough money. Please deposit some money in your wallet!");
            lbTitle.Text = "";
            btnDeposit.Visible = true;
            lbDeposit.Visible = true;
        }
        //////////////////////////
        private void Tasks_student_Load(object sender, EventArgs e)
        {
            timerTasks.Start();
        }
        private void btnMarkDone_Click(object sender, EventArgs e)
        {
            if (CheckIfSelected())
            {
                int indexOfSelectedTask = lbxUndoneTasks.SelectedIndex;
                string task = lbxUndoneTasks.Items[indexOfSelectedTask].ToString();
                if (task.ToLower().Contains("pay") == true)
                {
                    pnlDeposit.Visible = true;
                    lbTitle.Text = task;
                }
                else
                {
                    lbxDoneTasks.Items.Add(task);
                    lbxUndoneTasks.Items.RemoveAt(indexOfSelectedTask);
                }
               
            }
        }

        
        private void btnPayPenalty_Click(object sender, EventArgs e)
        {
            balance = GetBalance();
            if (balance - 15 < 0)
            {
                pnlDeposit.Visible = true;
                pnlDeposit.BringToFront();
                lbTitle.Text = "";
                btnDeposit.Visible = true;
                lbDeposit.Visible = true;
                
            }
            else
            {
                balance -= 15;
                student.SetBalance(balance);
                int indexOfSelectedPenalty = lbxPenalties.SelectedIndex;
                lbxPenalties.Items.RemoveAt(indexOfSelectedPenalty);
                counter--;
            }
        }

        private void timerTasks_Tick(object sender, EventArgs e)
        {
            counter++;
            lbxPenalties.Items.Add($"Penalty №{counter}! Please pay your penalty and do your tasks!");
            if (counter == 3)
            {
                timerTasks.Stop();
                lbTitle.Text = $"Pay your penalties to \n continue using this page!";
                pnlTasks.Enabled = false;
                btnPayPenalty.Enabled = true;
                pnlDeposit.Visible = true;
                pnlDeposit.Enabled= true;
                tbAmount.Text = "100";
            }
                
            
            
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            
            double amount = Convert.ToDouble(tbAmount.Text);
            balance = GetBalance();
            balance += amount;
            student.SetBalance(balance);
            btnDeposit.Visible = false;
            lbTitle.Text = "";
            lbDeposit.Visible = false;
            pnlDeposit.Visible = false;
            tbAmount.Clear();
            if (counter == 3)
            {
                pnlDeposit.Visible = true;
                tbAmount.Text = "100";
            }
        }
        

        private void btnPay_Click(object sender, EventArgs e)
        {
            double amount;
            
            balance = GetBalance();
            if (counter == 3)
            {
                amount = 100;
                if (IsPay(amount))
                {
                    Pay(amount);
                    lbxPenalties.Items.Clear();
                    pnlTasks.Enabled = true;
                    tbAmount.Clear();
                    counter = 0;
                    timerTasks.Start();
                }
                else
                {
                    Deposit(amount);
                    
                }
             }
            else
            if (double.TryParse(tbAmount.Text, out amount))
            {
                    int indexOfSelectedTask = lbxUndoneTasks.SelectedIndex;
                    string task = lbxUndoneTasks.Items[indexOfSelectedTask].ToString();
                    if (IsPay(amount))
                    {
                    Pay(amount);
                        lbxDoneTasks.Items.Add(task);
                        lbxUndoneTasks.Items.RemoveAt(indexOfSelectedTask);
                    lbTitle.Text = "";
                        
                    }
                    else
                    {
                    Deposit(amount);

                    }
                }
            
            else
            {
                MessageBox.Show("Please enter a valid amount!");
            }
            }

        private void tbAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPUndone_Click(object sender, EventArgs e)
        {

        }

        private void lbxDoneTasks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

     
    }

