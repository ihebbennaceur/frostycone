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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Removeproducts));
            btn_remove = new Button();
            tbx_proid = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_remove
            // 
            btn_remove.BackColor = SystemColors.ActiveCaptionText;
            btn_remove.FlatAppearance.BorderSize = 0;
            btn_remove.FlatStyle = FlatStyle.Flat;
            btn_remove.Font = new Font("Segoe UI", 12F);
            btn_remove.ForeColor = SystemColors.HighlightText;
            btn_remove.Location = new Point(105, 295);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(235, 35);
            btn_remove.TabIndex = 0;
            btn_remove.Text = "remove product";
            btn_remove.UseVisualStyleBackColor = false;
            btn_remove.Click += btn_remove_Click;
            // 
            // tbx_proid
            // 
            tbx_proid.Location = new Point(105, 249);
            tbx_proid.Name = "tbx_proid";
            tbx_proid.Size = new Size(235, 23);
            tbx_proid.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(94, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(255, 473);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(105, 231);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 3;
            label1.Text = "Enter product ID";
            // 
            // Removeproducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 508);
            Controls.Add(label1);
            Controls.Add(tbx_proid);
            Controls.Add(btn_remove);
            Controls.Add(pictureBox1);
            Name = "Removeproducts";
            Text = "Removeproducts";
            Load += Removeproducts_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_remove;
        private TextBox tbx_proid;
        private PictureBox pictureBox1;
        private Label label1;
    }
}