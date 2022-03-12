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
    public partial class Wallet : UserControl
    {
        public Student student;
        private double balance;
        
         public void SetStudent(Student student)
        {
            this.student = student; 
        }
        private double GetNewBalance()
        {
            return this.student.GetInitialBalance();
        }
        public Wallet()
        {
            InitializeComponent(); 

        }
        
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            balance = GetNewBalance();
            double amount = Convert.ToDouble(tbAmount.Text);
            string reason = tbReason.Text;
            balance += amount;
            student.SetBalance(balance);
            lblBalance.Text = (balance).ToString();
            lbxHistory.Items.Add($"Deposit {amount} Euro - {reason}");
            btnWithdraw.Enabled = true;
            ClearTextBoxes();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            balance = GetNewBalance();
            double amount = Convert.ToDouble(tbAmount.Text);
            string reason = tbReason.Text;
            if (balance - amount <= 0)
            {
                MessageBox.Show("You do not have enough money in your balance!");
                lbxHistory.Items.Add($"Failed withdraw for {amount} Euro - {reason}");
            }
            else
            {
                balance -= amount;
                lblBalance.Text = (balance).ToString();
                student.SetBalance(balance);
                lbxHistory.Items.Add($"Withdraw {amount} Euro - {reason}");
                
            }
            ClearTextBoxes();

        }
        
        private void ClearTextBoxes()
        {
            tbAmount.Text = "";
            tbReason.Text = "";
        }
        private void Wallet_Load(object sender, EventArgs e)
        {
            if (student == null)
                return;
            lblBalance.Text += $"{student.GetInitialBalance()}";
            lblBankAccount.Text += $"{student.GetBankAccount()}";
            lblName.Text += $"{student.GetName()}";
            

        }

        private void btnUpdateBalance_Click(object sender, EventArgs e)
        {
            balance = GetNewBalance();
            lblBalance.Text = balance.ToString();
        }
    }
}
