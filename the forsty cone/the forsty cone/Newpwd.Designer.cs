namespace the_forsty_cone
{
    partial class Newpwd
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
            tbx_password = new TextBox();
            tbx_confirmpassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btn_reset = new Button();
            btn_back = new Button();
            SuspendLayout();
            // 
            // tbx_password
            // 
            tbx_password.Location = new Point(165, 191);
            tbx_password.Name = "tbx_password";
            tbx_password.Size = new Size(100, 23);
            tbx_password.TabIndex = 0;
            tbx_password.TextChanged += textBox1_TextChanged;
            // 
            // tbx_confirmpassword
            // 
            tbx_confirmpassword.Location = new Point(165, 240);
            tbx_confirmpassword.Name = "tbx_confirmpassword";
            tbx_confirmpassword.Size = new Size(100, 23);
            tbx_confirmpassword.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 191);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 2;
            label1.Text = "New Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 248);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 3;
            label2.Text = "Confirm Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(128, 90);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 4;
            label3.Text = "Reset password";
            // 
            // btn_reset
            // 
            btn_reset.Location = new Point(118, 320);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(75, 23);
            btn_reset.TabIndex = 5;
            btn_reset.Text = "reset";
            btn_reset.UseVisualStyleBackColor = true;
            btn_reset.Click += btn_reset_Click;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(344, 79);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(101, 59);
            btn_back.TabIndex = 6;
            btn_back.Text = "back to frontpage";
            btn_back.UseVisualStyleBackColor = true;
            // 
            // Newpwd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_back);
            Controls.Add(btn_reset);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbx_confirmpassword);
            Controls.Add(tbx_password);
            Name = "Newpwd";
            Text = "Newpwd";
            Load += Newpwd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbx_password;
        private TextBox tbx_confirmpassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_reset;
        private Button btn_back;
    }
}