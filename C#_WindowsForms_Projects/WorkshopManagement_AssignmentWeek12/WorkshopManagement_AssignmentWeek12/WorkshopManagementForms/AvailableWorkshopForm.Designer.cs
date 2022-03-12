namespace WorkshopManagement_AssignmentWeek12
{
    partial class AvailableWorkshopForm
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
            this.lblAvailableWorkshops = new System.Windows.Forms.Label();
            this.gbChooseWorkshop = new System.Windows.Forms.GroupBox();
            this.btnShowAllWorkshops = new System.Windows.Forms.Button();
            this.lbxAvailableWorkshops = new System.Windows.Forms.ListBox();
            this.btnShowInBuildingWokrshops = new System.Windows.Forms.Button();
            this.btnShowOnlineWorkshops = new System.Windows.Forms.Button();
            this.gbChooseWorkshop.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAvailableWorkshops
            // 
            this.lblAvailableWorkshops.AutoSize = true;
            this.lblAvailableWorkshops.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAvailableWorkshops.Location = new System.Drawing.Point(12, 9);
            this.lblAvailableWorkshops.Name = "lblAvailableWorkshops";
            this.lblAvailableWorkshops.Size = new System.Drawing.Size(275, 32);
            this.lblAvailableWorkshops.TabIndex = 10;
            this.lblAvailableWorkshops.Text = "Available workshops";
            // 
            // gbChooseWorkshop
            // 
            this.gbChooseWorkshop.Controls.Add(this.btnShowAllWorkshops);
            this.gbChooseWorkshop.Controls.Add(this.lbxAvailableWorkshops);
            this.gbChooseWorkshop.Controls.Add(this.btnShowInBuildingWokrshops);
            this.gbChooseWorkshop.Controls.Add(this.btnShowOnlineWorkshops);
            this.gbChooseWorkshop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbChooseWorkshop.Location = new System.Drawing.Point(12, 44);
            this.gbChooseWorkshop.Name = "gbChooseWorkshop";
            this.gbChooseWorkshop.Size = new System.Drawing.Size(776, 312);
            this.gbChooseWorkshop.TabIndex = 11;
            this.gbChooseWorkshop.TabStop = false;
            // 
            // btnShowAllWorkshops
            // 
            this.btnShowAllWorkshops.Location = new System.Drawing.Point(588, 140);
            this.btnShowAllWorkshops.Name = "btnShowAllWorkshops";
            this.btnShowAllWorkshops.Size = new System.Drawing.Size(165, 34);
            this.btnShowAllWorkshops.TabIndex = 8;
            this.btnShowAllWorkshops.Text = "All workshops";
            this.btnShowAllWorkshops.UseVisualStyleBackColor = true;
            this.btnShowAllWorkshops.Click += new System.EventHandler(this.btnShowAllWorkshops_Click);
            // 
            // lbxAvailableWorkshops
            // 
            this.lbxAvailableWorkshops.FormattingEnabled = true;
            this.lbxAvailableWorkshops.HorizontalScrollbar = true;
            this.lbxAvailableWorkshops.ItemHeight = 22;
            this.lbxAvailableWorkshops.Location = new System.Drawing.Point(19, 27);
            this.lbxAvailableWorkshops.Name = "lbxAvailableWorkshops";
            this.lbxAvailableWorkshops.Size = new System.Drawing.Size(548, 246);
            this.lbxAvailableWorkshops.TabIndex = 7;
            // 
            // btnShowInBuildingWokrshops
            // 
            this.btnShowInBuildingWokrshops.Location = new System.Drawing.Point(588, 81);
            this.btnShowInBuildingWokrshops.Name = "btnShowInBuildingWokrshops";
            this.btnShowInBuildingWokrshops.Size = new System.Drawing.Size(165, 34);
            this.btnShowInBuildingWokrshops.TabIndex = 5;
            this.btnShowInBuildingWokrshops.Text = "InBuilding";
            this.btnShowInBuildingWokrshops.UseVisualStyleBackColor = true;
            this.btnShowInBuildingWokrshops.Click += new System.EventHandler(this.btnShowInBuildingWokrshops_Click);
            // 
            // btnShowOnlineWorkshops
            // 
            this.btnShowOnlineWorkshops.Location = new System.Drawing.Point(588, 27);
            this.btnShowOnlineWorkshops.Name = "btnShowOnlineWorkshops";
            this.btnShowOnlineWorkshops.Size = new System.Drawing.Size(165, 34);
            this.btnShowOnlineWorkshops.TabIndex = 4;
            this.btnShowOnlineWorkshops.Text = "Online";
            this.btnShowOnlineWorkshops.UseVisualStyleBackColor = true;
            this.btnShowOnlineWorkshops.Click += new System.EventHandler(this.btnShowOnlineWorkshops_Click);
            // 
            // AvailableWorkshopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 375);
            this.Controls.Add(this.gbChooseWorkshop);
            this.Controls.Add(this.lblAvailableWorkshops);
            this.Name = "AvailableWorkshopForm";
            this.Text = "AvailableWorkshopForm";
            this.gbChooseWorkshop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAvailableWorkshops;
        private System.Windows.Forms.GroupBox gbChooseWorkshop;
        private System.Windows.Forms.Button btnShowAllWorkshops;
        private System.Windows.Forms.ListBox lbxAvailableWorkshops;
        private System.Windows.Forms.Button btnShowInBuildingWokrshops;
        private System.Windows.Forms.Button btnShowOnlineWorkshops;
    }
}