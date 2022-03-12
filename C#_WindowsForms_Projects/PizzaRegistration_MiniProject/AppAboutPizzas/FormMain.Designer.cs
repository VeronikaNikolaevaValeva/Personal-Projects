namespace AppAboutPizzas
{
    partial class FormMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbStudentnumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbKindOfPizza = new System.Windows.Forms.ComboBox();
            this.btnRegisterChosenPizza = new System.Windows.Forms.Button();
            this.btnShowPizzaForStudent = new System.Windows.Forms.Button();
            this.lbInfo = new System.Windows.Forms.ListBox();
            this.btnShowAllPizzas = new System.Windows.Forms.Button();
            this.showStudents = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.groupBox1.Controls.Add(this.tbStudentnumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbKindOfPizza);
            this.groupBox1.Location = new System.Drawing.Point(13, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 378);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "input data";
            // 
            // tbStudentnumber
            // 
            this.tbStudentnumber.Location = new System.Drawing.Point(23, 64);
            this.tbStudentnumber.Name = "tbStudentnumber";
            this.tbStudentnumber.Size = new System.Drawing.Size(135, 30);
            this.tbStudentnumber.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "kind of pizza";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "student number";
            // 
            // cbKindOfPizza
            // 
            this.cbKindOfPizza.FormattingEnabled = true;
            this.cbKindOfPizza.Location = new System.Drawing.Point(6, 163);
            this.cbKindOfPizza.Name = "cbKindOfPizza";
            this.cbKindOfPizza.Size = new System.Drawing.Size(155, 33);
            this.cbKindOfPizza.TabIndex = 0;
            // 
            // btnRegisterChosenPizza
            // 
            this.btnRegisterChosenPizza.Location = new System.Drawing.Point(231, 97);
            this.btnRegisterChosenPizza.Name = "btnRegisterChosenPizza";
            this.btnRegisterChosenPizza.Size = new System.Drawing.Size(299, 44);
            this.btnRegisterChosenPizza.TabIndex = 1;
            this.btnRegisterChosenPizza.Text = "register chosen pizza";
            this.btnRegisterChosenPizza.UseVisualStyleBackColor = true;
            this.btnRegisterChosenPizza.Click += new System.EventHandler(this.btnRegisterChosenPizza_Click);
            // 
            // btnShowPizzaForStudent
            // 
            this.btnShowPizzaForStudent.Location = new System.Drawing.Point(230, 152);
            this.btnShowPizzaForStudent.Name = "btnShowPizzaForStudent";
            this.btnShowPizzaForStudent.Size = new System.Drawing.Size(300, 45);
            this.btnShowPizzaForStudent.TabIndex = 2;
            this.btnShowPizzaForStudent.Text = "show pizza for student";
            this.btnShowPizzaForStudent.UseVisualStyleBackColor = true;
            this.btnShowPizzaForStudent.Click += new System.EventHandler(this.btnShowPizzaForStudent_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.FormattingEnabled = true;
            this.lbInfo.ItemHeight = 25;
            this.lbInfo.Location = new System.Drawing.Point(193, 207);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(554, 204);
            this.lbInfo.TabIndex = 4;
            // 
            // btnShowAllPizzas
            // 
            this.btnShowAllPizzas.Location = new System.Drawing.Point(230, 12);
            this.btnShowAllPizzas.Name = "btnShowAllPizzas";
            this.btnShowAllPizzas.Size = new System.Drawing.Size(299, 31);
            this.btnShowAllPizzas.TabIndex = 6;
            this.btnShowAllPizzas.Text = "show all pizzas";
            this.btnShowAllPizzas.UseVisualStyleBackColor = true;
            this.btnShowAllPizzas.Click += new System.EventHandler(this.btnShowAllPizzas_Click);
            // 
            // showStudents
            // 
            this.showStudents.Location = new System.Drawing.Point(230, 49);
            this.showStudents.Name = "showStudents";
            this.showStudents.Size = new System.Drawing.Size(299, 29);
            this.showStudents.TabIndex = 7;
            this.showStudents.Text = "show all students";
            this.showStudents.UseVisualStyleBackColor = true;
            this.showStudents.Click += new System.EventHandler(this.showStudents_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 419);
            this.Controls.Add(this.showStudents);
            this.Controls.Add(this.btnShowAllPizzas);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.btnShowPizzaForStudent);
            this.Controls.Add(this.btnRegisterChosenPizza);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbStudentnumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKindOfPizza;
        private System.Windows.Forms.Button btnRegisterChosenPizza;
        private System.Windows.Forms.Button btnShowPizzaForStudent;
        private System.Windows.Forms.ListBox lbInfo;
        private System.Windows.Forms.Button btnShowAllPizzas;
        private System.Windows.Forms.Button showStudents;
    }
}

