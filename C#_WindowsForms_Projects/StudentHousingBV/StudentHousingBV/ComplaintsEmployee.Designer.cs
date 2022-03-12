namespace StudentHousingBV
{
    partial class ComplaintsEmployee
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
            this.pnlComplaintEmp = new System.Windows.Forms.Panel();
            this.lBComplaintsEmp = new System.Windows.Forms.ListBox();
            this.lblComplaintsEmp = new System.Windows.Forms.Label();
            this.pnlComplaintEmp.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlComplaintEmp
            // 
            this.pnlComplaintEmp.BackColor = System.Drawing.Color.Lavender;
            this.pnlComplaintEmp.Controls.Add(this.lblComplaintsEmp);
            this.pnlComplaintEmp.Controls.Add(this.lBComplaintsEmp);
            this.pnlComplaintEmp.Location = new System.Drawing.Point(16, 21);
            this.pnlComplaintEmp.Name = "pnlComplaintEmp";
            this.pnlComplaintEmp.Size = new System.Drawing.Size(783, 607);
            this.pnlComplaintEmp.TabIndex = 0;
            // 
            // lBComplaintsEmp
            // 
            this.lBComplaintsEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lBComplaintsEmp.FormattingEnabled = true;
            this.lBComplaintsEmp.ItemHeight = 29;
            this.lBComplaintsEmp.Items.AddRange(new object[] {
            "--> Loud noice - Alex Smith",
            "--> Dirty dishes on the second floor"});
            this.lBComplaintsEmp.Location = new System.Drawing.Point(34, 92);
            this.lBComplaintsEmp.Name = "lBComplaintsEmp";
            this.lBComplaintsEmp.Size = new System.Drawing.Size(709, 468);
            this.lBComplaintsEmp.TabIndex = 0;
            // 
            // lblComplaintsEmp
            // 
            this.lblComplaintsEmp.AutoSize = true;
            this.lblComplaintsEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblComplaintsEmp.Location = new System.Drawing.Point(28, 57);
            this.lblComplaintsEmp.Name = "lblComplaintsEmp";
            this.lblComplaintsEmp.Size = new System.Drawing.Size(158, 32);
            this.lblComplaintsEmp.TabIndex = 1;
            this.lblComplaintsEmp.Text = "Complaints";
            // 
            // ComplaintsEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlComplaintEmp);
            this.Name = "ComplaintsEmployee";
            this.Size = new System.Drawing.Size(828, 650);
            this.pnlComplaintEmp.ResumeLayout(false);
            this.pnlComplaintEmp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlComplaintEmp;
        private System.Windows.Forms.Label lblComplaintsEmp;
        private System.Windows.Forms.ListBox lBComplaintsEmp;
    }
}
