namespace StudentHousingBV
{
    partial class HouseRules
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
            this.pnlHouseRules = new System.Windows.Forms.Panel();
            this.lblHouseRules = new System.Windows.Forms.Label();
            this.lBHouseRules = new System.Windows.Forms.ListBox();
            this.pnlHouseRules.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHouseRules
            // 
            this.pnlHouseRules.BackColor = System.Drawing.Color.Lavender;
            this.pnlHouseRules.Controls.Add(this.lblHouseRules);
            this.pnlHouseRules.Controls.Add(this.lBHouseRules);
            this.pnlHouseRules.Location = new System.Drawing.Point(21, 24);
            this.pnlHouseRules.Name = "pnlHouseRules";
            this.pnlHouseRules.Size = new System.Drawing.Size(783, 607);
            this.pnlHouseRules.TabIndex = 1;
            // 
            // lblHouseRules
            // 
            this.lblHouseRules.AutoSize = true;
            this.lblHouseRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHouseRules.Location = new System.Drawing.Point(40, 64);
            this.lblHouseRules.Name = "lblHouseRules";
            this.lblHouseRules.Size = new System.Drawing.Size(174, 32);
            this.lblHouseRules.TabIndex = 1;
            this.lblHouseRules.Text = "House rules:";
            // 
            // lBHouseRules
            // 
            this.lBHouseRules.BackColor = System.Drawing.Color.Lavender;
            this.lBHouseRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lBHouseRules.FormattingEnabled = true;
            this.lBHouseRules.ItemHeight = 29;
            this.lBHouseRules.Items.AddRange(new object[] {
            "--> For your own safety and to keep escape routes clear, it is",
            " not allowed to place (private) objects or possessions of ",
            "yourself or of visitors in the common areas, staircases and ",
            "corridors.",
            "--> A non-smoking area applies in all common areas and ",
            "smoking is only permitted onthe site in the designated area.",
            "--> It is not permitted to carry out repairs or other work on ",
            "the pipes or ornaments of the stairs and/or gallery lighting. ",
            "Instead, inform our caretakers.",
            "--> It is forbidden to cycle in the parking garage.",
            "--> The maximum load of the elevators may not ",
            "be exceeded. Elevators cannot and may not be used in case ",
            "of fire. ",
            "--> It is not allowed to sublet your rental property to a ",
            "third party. When subletting your rental property, you will ",
            "risk a fine or a cancellation of your rental contract.",
            "--> Keeping pets is not allowed. Visitors\' pets are also ",
            "not allowed.",
            "--> Due to the water, electricity, gas and central heating ",
            "pipes in the screed and walls, ",
            "it is not allowed to hammer or drill into the floor and walls. ",
            "--> The employee reports his visit at least 1 day in advance",
            "by email."});
            this.lBHouseRules.Location = new System.Drawing.Point(43, 108);
            this.lBHouseRules.Name = "lBHouseRules";
            this.lBHouseRules.Size = new System.Drawing.Size(690, 439);
            this.lBHouseRules.TabIndex = 0;
            // 
            // HouseRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlHouseRules);
            this.Name = "HouseRules";
            this.Size = new System.Drawing.Size(828, 650);
            this.pnlHouseRules.ResumeLayout(false);
            this.pnlHouseRules.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlHouseRules;
        private System.Windows.Forms.ListBox lBHouseRules;
        private System.Windows.Forms.Label lblHouseRules;
    }
}
