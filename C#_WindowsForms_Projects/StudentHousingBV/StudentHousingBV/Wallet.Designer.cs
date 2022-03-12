namespace StudentHousingBV
{
    partial class Wallet
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBankAccount = new System.Windows.Forms.Label();
            this.labelbalance = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbcWallet = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbxHistory = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbReason = new System.Windows.Forms.TextBox();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnUpdateBalance = new System.Windows.Forms.Button();
            this.tbcWallet.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBankAccount
            // 
            this.lblBankAccount.AutoSize = true;
            this.lblBankAccount.BackColor = System.Drawing.Color.White;
            this.lblBankAccount.Font = new System.Drawing.Font("Roboto Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBankAccount.Location = new System.Drawing.Point(76, 143);
            this.lblBankAccount.Name = "lblBankAccount";
            this.lblBankAccount.Size = new System.Drawing.Size(177, 34);
            this.lblBankAccount.TabIndex = 24;
            this.lblBankAccount.Text = "Back account: ";
            // 
            // labelbalance
            // 
            this.labelbalance.AutoSize = true;
            this.labelbalance.BackColor = System.Drawing.Color.White;
            this.labelbalance.Font = new System.Drawing.Font("Roboto Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelbalance.Location = new System.Drawing.Point(76, 200);
            this.labelbalance.Name = "labelbalance";
            this.labelbalance.Size = new System.Drawing.Size(115, 34);
            this.labelbalance.TabIndex = 23;
            this.labelbalance.Text = "Balance: ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.Font = new System.Drawing.Font("Roboto Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(76, 85);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(92, 34);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "Name: ";
            // 
            // tbcWallet
            // 
            this.tbcWallet.Controls.Add(this.tabPage1);
            this.tbcWallet.Controls.Add(this.tabPage2);
            this.tbcWallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbcWallet.Location = new System.Drawing.Point(82, 263);
            this.tbcWallet.Margin = new System.Windows.Forms.Padding(4);
            this.tbcWallet.Name = "tbcWallet";
            this.tbcWallet.SelectedIndex = 0;
            this.tbcWallet.Size = new System.Drawing.Size(624, 317);
            this.tbcWallet.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbxHistory);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(616, 279);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbxHistory
            // 
            this.lbxHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbxHistory.FormattingEnabled = true;
            this.lbxHistory.ItemHeight = 25;
            this.lbxHistory.Location = new System.Drawing.Point(1, 1);
            this.lbxHistory.Margin = new System.Windows.Forms.Padding(4);
            this.lbxHistory.Name = "lbxHistory";
            this.lbxHistory.Size = new System.Drawing.Size(611, 254);
            this.lbxHistory.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbReason);
            this.tabPage2.Controls.Add(this.tbAmount);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnDeposit);
            this.tabPage2.Controls.Add(this.btnWithdraw);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(616, 279);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Deposit/Withdraw";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbReason
            // 
            this.tbReason.Location = new System.Drawing.Point(173, 80);
            this.tbReason.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbReason.Multiline = true;
            this.tbReason.Name = "tbReason";
            this.tbReason.Size = new System.Drawing.Size(419, 128);
            this.tbReason.TabIndex = 18;
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(173, 20);
            this.tbAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(209, 30);
            this.tbAmount.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(49, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Reason:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(49, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Amount:";
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.Lavender;
            this.btnDeposit.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeposit.Location = new System.Drawing.Point(54, 225);
            this.btnDeposit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(197, 38);
            this.btnDeposit.TabIndex = 13;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.Color.Lavender;
            this.btnWithdraw.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWithdraw.Location = new System.Drawing.Point(358, 225);
            this.btnWithdraw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(197, 38);
            this.btnWithdraw.TabIndex = 14;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.BackColor = System.Drawing.Color.White;
            this.lblBalance.Font = new System.Drawing.Font("Roboto Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBalance.Location = new System.Drawing.Point(206, 200);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(0, 34);
            this.lblBalance.TabIndex = 27;
            // 
            // btnUpdateBalance
            // 
            this.btnUpdateBalance.BackColor = System.Drawing.Color.Lavender;
            this.btnUpdateBalance.BackgroundImage = global::StudentHousingBV.Properties.Resources.update;
            this.btnUpdateBalance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateBalance.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdateBalance.Location = new System.Drawing.Point(32, 201);
            this.btnUpdateBalance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateBalance.Name = "btnUpdateBalance";
            this.btnUpdateBalance.Size = new System.Drawing.Size(38, 34);
            this.btnUpdateBalance.TabIndex = 19;
            this.btnUpdateBalance.UseVisualStyleBackColor = false;
            this.btnUpdateBalance.Click += new System.EventHandler(this.btnUpdateBalance_Click);
            // 
            // Wallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.btnUpdateBalance);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.tbcWallet);
            this.Controls.Add(this.lblBankAccount);
            this.Controls.Add(this.labelbalance);
            this.Controls.Add(this.lblName);
            this.Name = "Wallet";
            this.Size = new System.Drawing.Size(783, 607);
            this.Load += new System.EventHandler(this.Wallet_Load);
            this.tbcWallet.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBankAccount;
        private System.Windows.Forms.Label labelbalance;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TabControl tbcWallet;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox lbxHistory;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbReason;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button btnUpdateBalance;
    }
}
