namespace login
{
    partial class basket
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
            this.lbl_display = new System.Windows.Forms.Label();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.lbl_increase = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Order:";
            // 
            // lbl_display
            // 
            this.lbl_display.AutoSize = true;
            this.lbl_display.Location = new System.Drawing.Point(61, 103);
            this.lbl_display.Name = "lbl_display";
            this.lbl_display.Size = new System.Drawing.Size(35, 13);
            this.lbl_display.TabIndex = 1;
            this.lbl_display.Text = "label2";
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Location = new System.Drawing.Point(536, 103);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(44, 13);
            this.lbl_quantity.TabIndex = 2;
            this.lbl_quantity.Text = "quantity";
            // 
            // lbl_increase
            // 
            this.lbl_increase.AutoSize = true;
            this.lbl_increase.Location = new System.Drawing.Point(552, 126);
            this.lbl_increase.Name = "lbl_increase";
            this.lbl_increase.Size = new System.Drawing.Size(0, 13);
            this.lbl_increase.TabIndex = 3;
            // 
            // basket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_increase);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.lbl_display);
            this.Controls.Add(this.label1);
            this.Name = "basket";
            this.Text = "#";
            this.Load += new System.EventHandler(this.basket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_display;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.Label lbl_increase;
    }
}