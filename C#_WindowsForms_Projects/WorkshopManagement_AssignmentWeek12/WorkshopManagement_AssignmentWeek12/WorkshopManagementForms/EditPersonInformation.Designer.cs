namespace WorkshopManagement_AssignmentWeek12
{
    partial class EditPersonInformation
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbChangeInformation = new System.Windows.Forms.GroupBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.cbbChengeTypeOfPerson = new System.Windows.Forms.ComboBox();
            this.txbChangePCN = new System.Windows.Forms.TextBox();
            this.txbChangeName = new System.Windows.Forms.TextBox();
            this.lblChangeTypeOfPerson = new System.Windows.Forms.Label();
            this.lblChangePCN = new System.Windows.Forms.Label();
            this.lblChangeName = new System.Windows.Forms.Label();
            this.gbChangeInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbChangeInformation
            // 
            this.gbChangeInformation.Controls.Add(this.btnSaveChanges);
            this.gbChangeInformation.Controls.Add(this.cbbChengeTypeOfPerson);
            this.gbChangeInformation.Controls.Add(this.txbChangePCN);
            this.gbChangeInformation.Controls.Add(this.txbChangeName);
            this.gbChangeInformation.Controls.Add(this.lblChangeTypeOfPerson);
            this.gbChangeInformation.Controls.Add(this.lblChangePCN);
            this.gbChangeInformation.Controls.Add(this.lblChangeName);
            this.gbChangeInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbChangeInformation.Location = new System.Drawing.Point(13, 13);
            this.gbChangeInformation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbChangeInformation.Name = "gbChangeInformation";
            this.gbChangeInformation.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbChangeInformation.Size = new System.Drawing.Size(605, 310);
            this.gbChangeInformation.TabIndex = 5;
            this.gbChangeInformation.TabStop = false;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(269, 240);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(300, 42);
            this.btnSaveChanges.TabIndex = 8;
            this.btnSaveChanges.Text = "Save changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // cbbChengeTypeOfPerson
            // 
            this.cbbChengeTypeOfPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChengeTypeOfPerson.FormattingEnabled = true;
            this.cbbChengeTypeOfPerson.Items.AddRange(new object[] {
            "Student",
            "Teacher"});
            this.cbbChengeTypeOfPerson.Location = new System.Drawing.Point(269, 169);
            this.cbbChengeTypeOfPerson.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbChengeTypeOfPerson.Name = "cbbChengeTypeOfPerson";
            this.cbbChengeTypeOfPerson.Size = new System.Drawing.Size(299, 30);
            this.cbbChengeTypeOfPerson.TabIndex = 7;
            // 
            // txbChangePCN
            // 
            this.txbChangePCN.Location = new System.Drawing.Point(269, 105);
            this.txbChangePCN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbChangePCN.Name = "txbChangePCN";
            this.txbChangePCN.Size = new System.Drawing.Size(299, 28);
            this.txbChangePCN.TabIndex = 6;
            // 
            // txbChangeName
            // 
            this.txbChangeName.Location = new System.Drawing.Point(269, 44);
            this.txbChangeName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbChangeName.Name = "txbChangeName";
            this.txbChangeName.Size = new System.Drawing.Size(299, 28);
            this.txbChangeName.TabIndex = 5;
            // 
            // lblChangeTypeOfPerson
            // 
            this.lblChangeTypeOfPerson.AutoSize = true;
            this.lblChangeTypeOfPerson.Location = new System.Drawing.Point(30, 175);
            this.lblChangeTypeOfPerson.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChangeTypeOfPerson.Name = "lblChangeTypeOfPerson";
            this.lblChangeTypeOfPerson.Size = new System.Drawing.Size(211, 24);
            this.lblChangeTypeOfPerson.TabIndex = 3;
            this.lblChangeTypeOfPerson.Text = "Change type of person: ";
            // 
            // lblChangePCN
            // 
            this.lblChangePCN.AutoSize = true;
            this.lblChangePCN.Location = new System.Drawing.Point(30, 109);
            this.lblChangePCN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChangePCN.Name = "lblChangePCN";
            this.lblChangePCN.Size = new System.Drawing.Size(126, 24);
            this.lblChangePCN.TabIndex = 2;
            this.lblChangePCN.Text = "Change PCN:";
            // 
            // lblChangeName
            // 
            this.lblChangeName.AutoSize = true;
            this.lblChangeName.Location = new System.Drawing.Point(30, 44);
            this.lblChangeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChangeName.Name = "lblChangeName";
            this.lblChangeName.Size = new System.Drawing.Size(147, 24);
            this.lblChangeName.TabIndex = 1;
            this.lblChangeName.Text = "Change Names:";
            // 
            // EditPersonInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(636, 340);
            this.Controls.Add(this.gbChangeInformation);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditPersonInformation";
            this.Text = "EditPersonInformation";
            this.gbChangeInformation.ResumeLayout(false);
            this.gbChangeInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbChangeInformation;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.ComboBox cbbChengeTypeOfPerson;
        private System.Windows.Forms.TextBox txbChangePCN;
        private System.Windows.Forms.TextBox txbChangeName;
        private System.Windows.Forms.Label lblChangeTypeOfPerson;
        private System.Windows.Forms.Label lblChangePCN;
        private System.Windows.Forms.Label lblChangeName;
    }
}