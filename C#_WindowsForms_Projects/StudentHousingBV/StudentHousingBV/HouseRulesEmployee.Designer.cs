namespace StudentHousingBV
{
    partial class HouseRulesEmployee
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRemoveRule = new System.Windows.Forms.Button();
            this.btnAddRule = new System.Windows.Forms.Button();
            this.txtBAddRule = new System.Windows.Forms.TextBox();
            this.lblHouserules = new System.Windows.Forms.Label();
            this.lBHouseRulesEmp = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.btnRemoveRule);
            this.panel1.Controls.Add(this.btnAddRule);
            this.panel1.Controls.Add(this.txtBAddRule);
            this.panel1.Controls.Add(this.lblHouserules);
            this.panel1.Controls.Add(this.lBHouseRulesEmp);
            this.panel1.Location = new System.Drawing.Point(34, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 584);
            this.panel1.TabIndex = 0;
            // 
            // btnRemoveRule
            // 
            this.btnRemoveRule.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRemoveRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemoveRule.Location = new System.Drawing.Point(385, 485);
            this.btnRemoveRule.Name = "btnRemoveRule";
            this.btnRemoveRule.Size = new System.Drawing.Size(328, 40);
            this.btnRemoveRule.TabIndex = 4;
            this.btnRemoveRule.Text = "Remove selected rule";
            this.btnRemoveRule.UseVisualStyleBackColor = false;
            this.btnRemoveRule.Click += new System.EventHandler(this.btnRemoveRule_Click);
            // 
            // btnAddRule
            // 
            this.btnAddRule.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAddRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddRule.Location = new System.Drawing.Point(44, 485);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(328, 40);
            this.btnAddRule.TabIndex = 3;
            this.btnAddRule.Text = "Add rule";
            this.btnAddRule.UseVisualStyleBackColor = false;
            this.btnAddRule.Click += new System.EventHandler(this.btnAddRule_Click);
            // 
            // txtBAddRule
            // 
            this.txtBAddRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBAddRule.Location = new System.Drawing.Point(46, 435);
            this.txtBAddRule.Name = "txtBAddRule";
            this.txtBAddRule.Size = new System.Drawing.Size(667, 30);
            this.txtBAddRule.TabIndex = 2;
            // 
            // lblHouserules
            // 
            this.lblHouserules.AutoSize = true;
            this.lblHouserules.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHouserules.Location = new System.Drawing.Point(41, 43);
            this.lblHouserules.Name = "lblHouserules";
            this.lblHouserules.Size = new System.Drawing.Size(148, 29);
            this.lblHouserules.TabIndex = 1;
            this.lblHouserules.Text = "House rules:";
            // 
            // lBHouseRulesEmp
            // 
            this.lBHouseRulesEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lBHouseRulesEmp.FormattingEnabled = true;
            this.lBHouseRulesEmp.ItemHeight = 29;
            this.lBHouseRulesEmp.Items.AddRange(new object[] {
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
            this.lBHouseRulesEmp.Location = new System.Drawing.Point(44, 82);
            this.lBHouseRulesEmp.Name = "lBHouseRulesEmp";
            this.lBHouseRulesEmp.Size = new System.Drawing.Size(669, 323);
            this.lBHouseRulesEmp.TabIndex = 0;
            this.lBHouseRulesEmp.SelectedIndexChanged += new System.EventHandler(this.lBHouseRulesEmp_SelectedIndexChanged);
            // 
            // HouseRulesEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "HouseRulesEmployee";
            this.Size = new System.Drawing.Size(828, 650);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRemoveRule;
        private System.Windows.Forms.Button btnAddRule;
        private System.Windows.Forms.TextBox txtBAddRule;
        private System.Windows.Forms.Label lblHouserules;
        private System.Windows.Forms.ListBox lBHouseRulesEmp;
    }
}
