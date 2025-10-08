namespace the_forsty_cone
{
    partial class Frontpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frontpage));
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 25F);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(22, 132);
            button1.Name = "button1";
            button1.Size = new Size(422, 328);
            button1.TabIndex = 0;
            button1.Text = "See Menu!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F);
            label1.Location = new Point(70, 26);
            label1.Name = "label1";
            label1.Size = new Size(223, 41);
            label1.TabIndex = 1;
            label1.Text = "The frosty cone";
            // 
            // button2
            // 
            button2.Location = new Point(358, 22);
            button2.Name = "button2";
            button2.Size = new Size(86, 62);
            button2.TabIndex = 2;
            button2.Text = "Login/register";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Frontpage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrange;
            ClientSize = new Size(489, 493);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Frontpage";
            Text = "Frontpage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
    }
}