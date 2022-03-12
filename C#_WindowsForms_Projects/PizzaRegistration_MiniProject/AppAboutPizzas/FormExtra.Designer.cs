namespace AppAboutPizzas
{
    partial class FormExtra
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTopping = new System.Windows.Forms.TextBox();
            this.btnAddTopping = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "topping";
            // 
            // tbTopping
            // 
            this.tbTopping.Location = new System.Drawing.Point(95, 94);
            this.tbTopping.Name = "tbTopping";
            this.tbTopping.Size = new System.Drawing.Size(151, 24);
            this.tbTopping.TabIndex = 3;
            // 
            // btnAddTopping
            // 
            this.btnAddTopping.Location = new System.Drawing.Point(271, 94);
            this.btnAddTopping.Name = "btnAddTopping";
            this.btnAddTopping.Size = new System.Drawing.Size(162, 40);
            this.btnAddTopping.TabIndex = 4;
            this.btnAddTopping.Text = "add a topping";
            this.btnAddTopping.UseVisualStyleBackColor = true;
            this.btnAddTopping.Click += new System.EventHandler(this.btnAddTopping_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(36, 149);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(172, 36);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "close this window";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(667, 213);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddTopping);
            this.Controls.Add(this.tbTopping);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormExtra";
            this.Text = "FormExtra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTopping;
        private System.Windows.Forms.Button btnAddTopping;
        private System.Windows.Forms.Button btnClose;
    }
}