namespace Webshop
{
    partial class ToyCollectorForm
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
            this.lbToys = new System.Windows.Forms.ListBox();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbToys
            // 
            this.lbToys.FormattingEnabled = true;
            this.lbToys.ItemHeight = 25;
            this.lbToys.Location = new System.Drawing.Point(12, 12);
            this.lbToys.Name = "lbToys";
            this.lbToys.Size = new System.Drawing.Size(986, 304);
            this.lbToys.TabIndex = 0;
            // 
            // btnPurchase
            // 
            this.btnPurchase.Location = new System.Drawing.Point(242, 322);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(155, 48);
            this.btnPurchase.TabIndex = 1;
            this.btnPurchase.Text = "&Purchase";
            this.btnPurchase.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quantity:";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(116, 331);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(120, 31);
            this.tbQuantity.TabIndex = 3;
            // 
            // ToyCollectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 382);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.lbToys);
            this.Name = "ToyCollectorForm";
            this.Text = "ToyCollector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbToys;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbQuantity;
    }
}