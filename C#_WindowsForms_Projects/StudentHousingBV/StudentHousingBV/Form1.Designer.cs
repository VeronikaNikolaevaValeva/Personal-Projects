namespace StudentHousingBV
{
    partial class LogInPage
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
            this.cbbProfiles = new System.Windows.Forms.ComboBox();
            this.BtnLogIn = new System.Windows.Forms.Button();
            this.rBEmployee = new System.Windows.Forms.RadioButton();
            this.rBStudents = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbProfiles
            // 
            this.cbbProfiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbbProfiles.FormattingEnabled = true;
            this.cbbProfiles.Location = new System.Drawing.Point(179, 489);
            this.cbbProfiles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbProfiles.Name = "cbbProfiles";
            this.cbbProfiles.Size = new System.Drawing.Size(747, 39);
            this.cbbProfiles.TabIndex = 3;
            // 
            // BtnLogIn
            // 
            this.BtnLogIn.BackColor = System.Drawing.Color.Lavender;
            this.BtnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnLogIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnLogIn.Location = new System.Drawing.Point(476, 560);
            this.BtnLogIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnLogIn.Name = "BtnLogIn";
            this.BtnLogIn.Size = new System.Drawing.Size(181, 59);
            this.BtnLogIn.TabIndex = 4;
            this.BtnLogIn.Text = "Log in";
            this.BtnLogIn.UseVisualStyleBackColor = false;
            this.BtnLogIn.Click += new System.EventHandler(this.BtnLogIn_Click);
            // 
            // rBEmployee
            // 
            this.rBEmployee.AutoSize = true;
            this.rBEmployee.BackColor = System.Drawing.Color.Transparent;
            this.rBEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rBEmployee.Location = new System.Drawing.Point(287, 415);
            this.rBEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBEmployee.Name = "rBEmployee";
            this.rBEmployee.Size = new System.Drawing.Size(163, 36);
            this.rBEmployee.TabIndex = 5;
            this.rBEmployee.TabStop = true;
            this.rBEmployee.Text = "Employee";
            this.rBEmployee.UseVisualStyleBackColor = false;
            this.rBEmployee.CheckedChanged += new System.EventHandler(this.rBEmployee_CheckedChanged);
            // 
            // rBStudents
            // 
            this.rBStudents.AutoSize = true;
            this.rBStudents.BackColor = System.Drawing.Color.Transparent;
            this.rBStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rBStudents.Location = new System.Drawing.Point(692, 415);
            this.rBStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBStudents.Name = "rBStudents";
            this.rBStudents.Size = new System.Drawing.Size(135, 36);
            this.rBStudents.TabIndex = 6;
            this.rBStudents.TabStop = true;
            this.rBStudents.Text = "Student";
            this.rBStudents.UseVisualStyleBackColor = false;
            this.rBStudents.CheckedChanged += new System.EventHandler(this.rBStudents_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StudentHousingBV.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(343, -12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(446, 422);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // LogInPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1083, 654);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rBStudents);
            this.Controls.Add(this.rBEmployee);
            this.Controls.Add(this.BtnLogIn);
            this.Controls.Add(this.cbbProfiles);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LogInPage";
            this.Text = "StudentHousingBV";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbbProfiles;
        private System.Windows.Forms.Button BtnLogIn;
        private System.Windows.Forms.RadioButton rBEmployee;
        private System.Windows.Forms.RadioButton rBStudents;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

