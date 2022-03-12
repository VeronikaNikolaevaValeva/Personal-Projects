namespace StudentHousingBV
{
    partial class ManageAccountsEmployee
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
            this.grbManageAccounts = new System.Windows.Forms.GroupBox();
            this.btnShowAllStudents = new System.Windows.Forms.Button();
            this.btnAccountInfo = new System.Windows.Forms.Button();
            this.txtbAccountInfo = new System.Windows.Forms.RichTextBox();
            this.lsbAllStudents = new System.Windows.Forms.ListBox();
            this.grbManageAccounts.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbManageAccounts
            // 
            this.grbManageAccounts.BackColor = System.Drawing.Color.Lavender;
            this.grbManageAccounts.Controls.Add(this.lsbAllStudents);
            this.grbManageAccounts.Controls.Add(this.btnShowAllStudents);
            this.grbManageAccounts.Controls.Add(this.btnAccountInfo);
            this.grbManageAccounts.Controls.Add(this.txtbAccountInfo);
            this.grbManageAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grbManageAccounts.Location = new System.Drawing.Point(33, 35);
            this.grbManageAccounts.Name = "grbManageAccounts";
            this.grbManageAccounts.Size = new System.Drawing.Size(756, 582);
            this.grbManageAccounts.TabIndex = 0;
            this.grbManageAccounts.TabStop = false;
            this.grbManageAccounts.Text = "Manage student accounts";
            // 
            // btnShowAllStudents
            // 
            this.btnShowAllStudents.Location = new System.Drawing.Point(44, 63);
            this.btnShowAllStudents.Name = "btnShowAllStudents";
            this.btnShowAllStudents.Size = new System.Drawing.Size(285, 43);
            this.btnShowAllStudents.TabIndex = 5;
            this.btnShowAllStudents.Text = "Show all students";
            this.btnShowAllStudents.UseVisualStyleBackColor = true;
            this.btnShowAllStudents.Click += new System.EventHandler(this.btnShowAllStudents_Click);
            // 
            // btnAccountInfo
            // 
            this.btnAccountInfo.Location = new System.Drawing.Point(44, 403);
            this.btnAccountInfo.Name = "btnAccountInfo";
            this.btnAccountInfo.Size = new System.Drawing.Size(285, 40);
            this.btnAccountInfo.TabIndex = 3;
            this.btnAccountInfo.Text = "Show account info";
            this.btnAccountInfo.UseVisualStyleBackColor = true;
            this.btnAccountInfo.Click += new System.EventHandler(this.btnAccountInfo_Click);
            // 
            // txtbAccountInfo
            // 
            this.txtbAccountInfo.Location = new System.Drawing.Point(44, 458);
            this.txtbAccountInfo.Name = "txtbAccountInfo";
            this.txtbAccountInfo.Size = new System.Drawing.Size(667, 79);
            this.txtbAccountInfo.TabIndex = 2;
            this.txtbAccountInfo.Text = "";
            // 
            // lsbAllStudents
            // 
            this.lsbAllStudents.FormattingEnabled = true;
            this.lsbAllStudents.ItemHeight = 31;
            this.lsbAllStudents.Location = new System.Drawing.Point(44, 123);
            this.lsbAllStudents.Name = "lsbAllStudents";
            this.lsbAllStudents.Size = new System.Drawing.Size(667, 252);
            this.lsbAllStudents.TabIndex = 6;
            // 
            // ManageAccountsEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.grbManageAccounts);
            this.Name = "ManageAccountsEmployee";
            this.Size = new System.Drawing.Size(824, 650);
            this.grbManageAccounts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbManageAccounts;
        private System.Windows.Forms.Button btnAccountInfo;
        private System.Windows.Forms.RichTextBox txtbAccountInfo;
        private System.Windows.Forms.Button btnShowAllStudents;
        private System.Windows.Forms.ListBox lsbAllStudents;
    }
}
