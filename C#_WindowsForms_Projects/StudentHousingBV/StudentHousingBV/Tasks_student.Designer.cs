namespace StudentHousingBV
{
    partial class Tasks_student
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
            this.components = new System.ComponentModel.Container();
            this.pnlTasks = new System.Windows.Forms.Panel();
            this.tbcTasks = new System.Windows.Forms.TabControl();
            this.tbPUndone = new System.Windows.Forms.TabPage();
            this.lbTimePenalty3 = new System.Windows.Forms.Label();
            this.lbTimePenalty2 = new System.Windows.Forms.Label();
            this.lbTimePenalty1 = new System.Windows.Forms.Label();
            this.btnMarkDone = new System.Windows.Forms.Button();
            this.lbxUndoneTasks = new System.Windows.Forms.ListBox();
            this.tbPDone = new System.Windows.Forms.TabPage();
            this.lbxDoneTasks = new System.Windows.Forms.ListBox();
            this.tbPPenalty = new System.Windows.Forms.TabPage();
            this.btnPayPenalty = new System.Windows.Forms.Button();
            this.lbxPenalties = new System.Windows.Forms.ListBox();
            this.timerTasks = new System.Windows.Forms.Timer(this.components);
            this.pnlDeposit = new System.Windows.Forms.Panel();
            this.lbDeposit = new System.Windows.Forms.Label();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.pnlTasks.SuspendLayout();
            this.tbcTasks.SuspendLayout();
            this.tbPUndone.SuspendLayout();
            this.tbPDone.SuspendLayout();
            this.tbPPenalty.SuspendLayout();
            this.pnlDeposit.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTasks
            // 
            this.pnlTasks.BackColor = System.Drawing.Color.Lavender;
            this.pnlTasks.Controls.Add(this.tbcTasks);
            this.pnlTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pnlTasks.Location = new System.Drawing.Point(21, 22);
            this.pnlTasks.Name = "pnlTasks";
            this.pnlTasks.Size = new System.Drawing.Size(783, 607);
            this.pnlTasks.TabIndex = 1;
            // 
            // tbcTasks
            // 
            this.tbcTasks.Controls.Add(this.tbPUndone);
            this.tbcTasks.Controls.Add(this.tbPDone);
            this.tbcTasks.Controls.Add(this.tbPPenalty);
            this.tbcTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbcTasks.Location = new System.Drawing.Point(32, 35);
            this.tbcTasks.Name = "tbcTasks";
            this.tbcTasks.SelectedIndex = 0;
            this.tbcTasks.Size = new System.Drawing.Size(716, 537);
            this.tbcTasks.TabIndex = 0;
            // 
            // tbPUndone
            // 
            this.tbPUndone.BackColor = System.Drawing.Color.Lavender;
            this.tbPUndone.Controls.Add(this.lbTimePenalty3);
            this.tbPUndone.Controls.Add(this.lbTimePenalty2);
            this.tbPUndone.Controls.Add(this.lbTimePenalty1);
            this.tbPUndone.Controls.Add(this.btnMarkDone);
            this.tbPUndone.Controls.Add(this.lbxUndoneTasks);
            this.tbPUndone.Location = new System.Drawing.Point(4, 38);
            this.tbPUndone.Name = "tbPUndone";
            this.tbPUndone.Padding = new System.Windows.Forms.Padding(3);
            this.tbPUndone.Size = new System.Drawing.Size(708, 495);
            this.tbPUndone.TabIndex = 0;
            this.tbPUndone.Text = "Undone";
            this.tbPUndone.Click += new System.EventHandler(this.tbPUndone_Click);
            // 
            // lbTimePenalty3
            // 
            this.lbTimePenalty3.AutoSize = true;
            this.lbTimePenalty3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTimePenalty3.Location = new System.Drawing.Point(462, 83);
            this.lbTimePenalty3.Name = "lbTimePenalty3";
            this.lbTimePenalty3.Size = new System.Drawing.Size(0, 25);
            this.lbTimePenalty3.TabIndex = 8;
            // 
            // lbTimePenalty2
            // 
            this.lbTimePenalty2.AutoSize = true;
            this.lbTimePenalty2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTimePenalty2.Location = new System.Drawing.Point(462, 49);
            this.lbTimePenalty2.Name = "lbTimePenalty2";
            this.lbTimePenalty2.Size = new System.Drawing.Size(0, 25);
            this.lbTimePenalty2.TabIndex = 6;
            // 
            // lbTimePenalty1
            // 
            this.lbTimePenalty1.AutoSize = true;
            this.lbTimePenalty1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTimePenalty1.Location = new System.Drawing.Point(462, 18);
            this.lbTimePenalty1.Name = "lbTimePenalty1";
            this.lbTimePenalty1.Size = new System.Drawing.Size(0, 25);
            this.lbTimePenalty1.TabIndex = 5;
            // 
            // btnMarkDone
            // 
            this.btnMarkDone.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMarkDone.Location = new System.Drawing.Point(392, 414);
            this.btnMarkDone.Name = "btnMarkDone";
            this.btnMarkDone.Size = new System.Drawing.Size(286, 44);
            this.btnMarkDone.TabIndex = 4;
            this.btnMarkDone.Text = "Mark as done";
            this.btnMarkDone.UseVisualStyleBackColor = false;
            this.btnMarkDone.Click += new System.EventHandler(this.btnMarkDone_Click);
            // 
            // lbxUndoneTasks
            // 
            this.lbxUndoneTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbxUndoneTasks.ForeColor = System.Drawing.Color.DarkRed;
            this.lbxUndoneTasks.FormattingEnabled = true;
            this.lbxUndoneTasks.ItemHeight = 29;
            this.lbxUndoneTasks.Items.AddRange(new object[] {
            "--> Wash the dishes",
            "--> Clean the stairway",
            "--> Pay 5 Euro for toilet paper"});
            this.lbxUndoneTasks.Location = new System.Drawing.Point(23, 18);
            this.lbxUndoneTasks.Name = "lbxUndoneTasks";
            this.lbxUndoneTasks.Size = new System.Drawing.Size(655, 381);
            this.lbxUndoneTasks.TabIndex = 0;
            // 
            // tbPDone
            // 
            this.tbPDone.BackColor = System.Drawing.Color.Lavender;
            this.tbPDone.Controls.Add(this.lbxDoneTasks);
            this.tbPDone.Location = new System.Drawing.Point(4, 38);
            this.tbPDone.Name = "tbPDone";
            this.tbPDone.Padding = new System.Windows.Forms.Padding(3);
            this.tbPDone.Size = new System.Drawing.Size(708, 495);
            this.tbPDone.TabIndex = 1;
            this.tbPDone.Text = "Done";
            // 
            // lbxDoneTasks
            // 
            this.lbxDoneTasks.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbxDoneTasks.FormattingEnabled = true;
            this.lbxDoneTasks.ItemHeight = 29;
            this.lbxDoneTasks.Items.AddRange(new object[] {
            "--> Pay for kitchen utilities",
            "--> Clean the bathroom"});
            this.lbxDoneTasks.Location = new System.Drawing.Point(18, 30);
            this.lbxDoneTasks.Name = "lbxDoneTasks";
            this.lbxDoneTasks.Size = new System.Drawing.Size(672, 439);
            this.lbxDoneTasks.TabIndex = 0;
            this.lbxDoneTasks.SelectedIndexChanged += new System.EventHandler(this.lbxDoneTasks_SelectedIndexChanged);
            // 
            // tbPPenalty
            // 
            this.tbPPenalty.BackColor = System.Drawing.Color.Lavender;
            this.tbPPenalty.Controls.Add(this.btnPayPenalty);
            this.tbPPenalty.Controls.Add(this.lbxPenalties);
            this.tbPPenalty.Location = new System.Drawing.Point(4, 38);
            this.tbPPenalty.Name = "tbPPenalty";
            this.tbPPenalty.Size = new System.Drawing.Size(708, 495);
            this.tbPPenalty.TabIndex = 2;
            this.tbPPenalty.Text = "Penalties";
            // 
            // btnPayPenalty
            // 
            this.btnPayPenalty.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPayPenalty.Location = new System.Drawing.Point(497, 427);
            this.btnPayPenalty.Name = "btnPayPenalty";
            this.btnPayPenalty.Size = new System.Drawing.Size(150, 44);
            this.btnPayPenalty.TabIndex = 17;
            this.btnPayPenalty.Text = "Pay";
            this.btnPayPenalty.UseVisualStyleBackColor = false;
            this.btnPayPenalty.Click += new System.EventHandler(this.btnPayPenalty_Click);
            // 
            // lbxPenalties
            // 
            this.lbxPenalties.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbxPenalties.ForeColor = System.Drawing.Color.DarkRed;
            this.lbxPenalties.FormattingEnabled = true;
            this.lbxPenalties.ItemHeight = 29;
            this.lbxPenalties.Location = new System.Drawing.Point(25, 27);
            this.lbxPenalties.Name = "lbxPenalties";
            this.lbxPenalties.Size = new System.Drawing.Size(655, 381);
            this.lbxPenalties.TabIndex = 1;
            // 
            // timerTasks
            // 
            this.timerTasks.Interval = 300000;
            this.timerTasks.Tick += new System.EventHandler(this.timerTasks_Tick);
            // 
            // pnlDeposit
            // 
            this.pnlDeposit.BackColor = System.Drawing.Color.Lavender;
            this.pnlDeposit.Controls.Add(this.lbDeposit);
            this.pnlDeposit.Controls.Add(this.btnDeposit);
            this.pnlDeposit.Controls.Add(this.btnPay);
            this.pnlDeposit.Controls.Add(this.lbTitle);
            this.pnlDeposit.Controls.Add(this.label1);
            this.pnlDeposit.Controls.Add(this.tbAmount);
            this.pnlDeposit.Location = new System.Drawing.Point(196, 193);
            this.pnlDeposit.Name = "pnlDeposit";
            this.pnlDeposit.Size = new System.Drawing.Size(433, 265);
            this.pnlDeposit.TabIndex = 12;
            this.pnlDeposit.Visible = false;
            // 
            // lbDeposit
            // 
            this.lbDeposit.AutoSize = true;
            this.lbDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDeposit.Location = new System.Drawing.Point(38, 22);
            this.lbDeposit.Name = "lbDeposit";
            this.lbDeposit.Size = new System.Drawing.Size(326, 29);
            this.lbDeposit.TabIndex = 17;
            this.lbDeposit.Text = "Deposit money in your wallet!";
            this.lbDeposit.Visible = false;
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeposit.Location = new System.Drawing.Point(143, 184);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(150, 44);
            this.btnDeposit.TabIndex = 16;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Visible = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPay.Location = new System.Drawing.Point(143, 184);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(150, 44);
            this.btnPay.TabIndex = 15;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTitle.Location = new System.Drawing.Point(38, 22);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(0, 25);
            this.lbTitle.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(86, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Amount";
            // 
            // tbAmount
            // 
            this.tbAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAmount.Location = new System.Drawing.Point(193, 94);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(160, 30);
            this.tbAmount.TabIndex = 12;
            this.tbAmount.TextChanged += new System.EventHandler(this.tbAmount_TextChanged);
            // 
            // Tasks_student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlDeposit);
            this.Controls.Add(this.pnlTasks);
            this.Name = "Tasks_student";
            this.Size = new System.Drawing.Size(824, 650);
            this.Load += new System.EventHandler(this.Tasks_student_Load);
            this.pnlTasks.ResumeLayout(false);
            this.tbcTasks.ResumeLayout(false);
            this.tbPUndone.ResumeLayout(false);
            this.tbPUndone.PerformLayout();
            this.tbPDone.ResumeLayout(false);
            this.tbPPenalty.ResumeLayout(false);
            this.pnlDeposit.ResumeLayout(false);
            this.pnlDeposit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTasks;
        private System.Windows.Forms.TabControl tbcTasks;
        private System.Windows.Forms.TabPage tbPUndone;
        private System.Windows.Forms.Button btnMarkDone;
        private System.Windows.Forms.ListBox lbxUndoneTasks;
        private System.Windows.Forms.TabPage tbPDone;
        private System.Windows.Forms.ListBox lbxDoneTasks;
        private System.Windows.Forms.TabPage tbPPenalty;
        private System.Windows.Forms.Label lbTimePenalty3;
        private System.Windows.Forms.Label lbTimePenalty2;
        private System.Windows.Forms.Label lbTimePenalty1;
        private System.Windows.Forms.ListBox lbxPenalties;
        private System.Windows.Forms.Button btnPayPenalty;
        private System.Windows.Forms.Timer timerTasks;
        private System.Windows.Forms.Panel pnlDeposit;
        private System.Windows.Forms.Label lbDeposit;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAmount;
    }
}
