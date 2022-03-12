namespace Webshop
{
    partial class BargainHunterForm
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
            this.btnPurchase = new System.Windows.Forms.Button();
            this.lbBargains = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPriceLimit = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 250);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quantity:";
            // 
            // btnPurchase
            // 
            this.btnPurchase.Location = new System.Drawing.Point(161, 243);
            this.btnPurchase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(103, 31);
            this.btnPurchase.TabIndex = 5;
            this.btnPurchase.Text = "&Purchase";
            this.btnPurchase.UseVisualStyleBackColor = true;
            // 
            // lbBargains
            // 
            this.lbBargains.FormattingEnabled = true;
            this.lbBargains.ItemHeight = 16;
            this.lbBargains.Location = new System.Drawing.Point(8, 44);
            this.lbBargains.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbBargains.Name = "lbBargains";
            this.lbBargains.Size = new System.Drawing.Size(659, 196);
            this.lbBargains.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Desired price limit:";
            // 
            // tbPriceLimit
            // 
            this.tbPriceLimit.Location = new System.Drawing.Point(138, 13);
            this.tbPriceLimit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPriceLimit.Name = "tbPriceLimit";
            this.tbPriceLimit.Size = new System.Drawing.Size(68, 22);
            this.tbPriceLimit.TabIndex = 9;
            this.tbPriceLimit.TextChanged += new System.EventHandler(this.tbPriceLimit_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(209, 8);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(183, 31);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "&Update for new bargains";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(77, 248);
            this.tbQuantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(68, 22);
            this.tbQuantity.TabIndex = 11;
            // 
            // BargainHunterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 284);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbPriceLimit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.lbBargains);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BargainHunterForm";
            this.Text = "BargainHunterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.ListBox lbBargains;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPriceLimit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbQuantity;
    }
}