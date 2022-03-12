namespace StudentHousingBV
{
    partial class CommonQuestionsEmployee
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpView = new System.Windows.Forms.TabPage();
            this.tbpEdit = new System.Windows.Forms.TabPage();
            this.lblCmnQestions = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lsbEditCommonQuestions = new System.Windows.Forms.ListBox();
            this.txtbAddQuestion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRemoveCommonQuestion = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.lsbCommonQuestionsView = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tbpView.SuspendLayout();
            this.tbpEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpView);
            this.tabControl1.Controls.Add(this.tbpEdit);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(34, 63);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(757, 549);
            this.tabControl1.TabIndex = 0;
            // 
            // tbpView
            // 
            this.tbpView.BackColor = System.Drawing.Color.Lavender;
            this.tbpView.Controls.Add(this.lsbCommonQuestionsView);
            this.tbpView.Controls.Add(this.label1);
            this.tbpView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbpView.Location = new System.Drawing.Point(4, 40);
            this.tbpView.Name = "tbpView";
            this.tbpView.Padding = new System.Windows.Forms.Padding(3);
            this.tbpView.Size = new System.Drawing.Size(749, 505);
            this.tbpView.TabIndex = 0;
            this.tbpView.Text = "View";
            // 
            // tbpEdit
            // 
            this.tbpEdit.BackColor = System.Drawing.Color.Lavender;
            this.tbpEdit.Controls.Add(this.btnAddQuestion);
            this.tbpEdit.Controls.Add(this.label4);
            this.tbpEdit.Controls.Add(this.btnRemoveCommonQuestion);
            this.tbpEdit.Controls.Add(this.label3);
            this.tbpEdit.Controls.Add(this.txtbAddQuestion);
            this.tbpEdit.Controls.Add(this.lsbEditCommonQuestions);
            this.tbpEdit.Controls.Add(this.label2);
            this.tbpEdit.Location = new System.Drawing.Point(4, 40);
            this.tbpEdit.Name = "tbpEdit";
            this.tbpEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEdit.Size = new System.Drawing.Size(749, 505);
            this.tbpEdit.TabIndex = 1;
            this.tbpEdit.Text = "Edit";
            // 
            // lblCmnQestions
            // 
            this.lblCmnQestions.AutoSize = true;
            this.lblCmnQestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCmnQestions.Location = new System.Drawing.Point(28, 28);
            this.lblCmnQestions.Name = "lblCmnQestions";
            this.lblCmnQestions.Size = new System.Drawing.Size(259, 32);
            this.lblCmnQestions.TabIndex = 1;
            this.lblCmnQestions.Text = "Common questions";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(639, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Common questions that are available for students";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(649, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Add and/or remove questions from the application.";
            // 
            // lsbEditCommonQuestions
            // 
            this.lsbEditCommonQuestions.FormattingEnabled = true;
            this.lsbEditCommonQuestions.ItemHeight = 31;
            this.lsbEditCommonQuestions.Items.AddRange(new object[] {
            "What is my student number?",
            "What is my bank account number?",
            "What is my room number?",
            "How can I get in touch with one of the employees?"});
            this.lsbEditCommonQuestions.Location = new System.Drawing.Point(37, 67);
            this.lsbEditCommonQuestions.Name = "lsbEditCommonQuestions";
            this.lsbEditCommonQuestions.Size = new System.Drawing.Size(671, 159);
            this.lsbEditCommonQuestions.TabIndex = 1;
            // 
            // txtbAddQuestion
            // 
            this.txtbAddQuestion.Location = new System.Drawing.Point(37, 374);
            this.txtbAddQuestion.Name = "txtbAddQuestion";
            this.txtbAddQuestion.Size = new System.Drawing.Size(671, 38);
            this.txtbAddQuestion.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Add a question:";
            // 
            // btnRemoveCommonQuestion
            // 
            this.btnRemoveCommonQuestion.Location = new System.Drawing.Point(423, 251);
            this.btnRemoveCommonQuestion.Name = "btnRemoveCommonQuestion";
            this.btnRemoveCommonQuestion.Size = new System.Drawing.Size(285, 40);
            this.btnRemoveCommonQuestion.TabIndex = 4;
            this.btnRemoveCommonQuestion.Text = "Remove";
            this.btnRemoveCommonQuestion.UseVisualStyleBackColor = true;
            this.btnRemoveCommonQuestion.Click += new System.EventHandler(this.btnRemoveCommonQuestion_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(366, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Select a question to remove";
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Location = new System.Drawing.Point(423, 427);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(285, 40);
            this.btnAddQuestion.TabIndex = 6;
            this.btnAddQuestion.Text = "Add question";
            this.btnAddQuestion.UseVisualStyleBackColor = true;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // lsbCommonQuestionsView
            // 
            this.lsbCommonQuestionsView.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lsbCommonQuestionsView.FormattingEnabled = true;
            this.lsbCommonQuestionsView.ItemHeight = 31;
            this.lsbCommonQuestionsView.Items.AddRange(new object[] {
            "What is my student number?",
            "What is my bank account number?",
            "What is my room number?",
            "How can I get in touch with one of the employees?"});
            this.lsbCommonQuestionsView.Location = new System.Drawing.Point(31, 88);
            this.lsbCommonQuestionsView.Name = "lsbCommonQuestionsView";
            this.lsbCommonQuestionsView.Size = new System.Drawing.Size(686, 376);
            this.lsbCommonQuestionsView.TabIndex = 1;
            // 
            // CommonQuestionsEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.lblCmnQestions);
            this.Controls.Add(this.tabControl1);
            this.Name = "CommonQuestionsEmployee";
            this.Size = new System.Drawing.Size(824, 650);
            this.tabControl1.ResumeLayout(false);
            this.tbpView.ResumeLayout(false);
            this.tbpView.PerformLayout();
            this.tbpEdit.ResumeLayout(false);
            this.tbpEdit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpView;
        private System.Windows.Forms.TabPage tbpEdit;
        private System.Windows.Forms.Label lblCmnQestions;
        private System.Windows.Forms.ListBox lsbCommonQuestionsView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRemoveCommonQuestion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbAddQuestion;
        private System.Windows.Forms.ListBox lsbEditCommonQuestions;
        private System.Windows.Forms.Label label2;
    }
}
