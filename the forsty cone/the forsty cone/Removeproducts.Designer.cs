namespace the_forsty_cone
{
    partial class Removeproducts
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
            btn_remove = new Button();
            tbx_proid = new TextBox();
            SuspendLayout();
            // 
            // btn_remove
            // 
            btn_remove.BackColor = Color.OrangeRed;
            btn_remove.Font = new Font("Segoe UI", 12F);
            btn_remove.ForeColor = SystemColors.HighlightText;
            btn_remove.Location = new Point(204, 294);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(121, 56);
            btn_remove.TabIndex = 0;
            btn_remove.Text = "remove product";
            btn_remove.UseVisualStyleBackColor = false;
            btn_remove.Click += btn_remove_Click;
            // 
            // tbx_proid
            // 
            tbx_proid.Location = new Point(213, 245);
            tbx_proid.Name = "tbx_proid";
            tbx_proid.Size = new Size(100, 23);
            tbx_proid.TabIndex = 1;
            // 
            // Removeproducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 508);
            Controls.Add(tbx_proid);
            Controls.Add(btn_remove);
            Name = "Removeproducts";
            Text = "Removeproducts";
            Load += Removeproducts_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_remove;
        private TextBox tbx_proid;
    }
}