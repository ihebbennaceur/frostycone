namespace the_forsty_cone
{
    partial class ForgotPassword
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
            lbl_username = new Label();
            lbl_dob = new Label();
            lbl_email = new Label();
            tbx_username = new TextBox();
            tbx_dob = new TextBox();
            button1 = new Button();
            tbx_email = new TextBox();
            reset = new Label();
            SuspendLayout();
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Location = new Point(93, 154);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(59, 15);
            lbl_username.TabIndex = 0;
            lbl_username.Text = "username";
            // 
            // lbl_dob
            // 
            lbl_dob.AutoSize = true;
            lbl_dob.Location = new Point(93, 263);
            lbl_dob.Name = "lbl_dob";
            lbl_dob.Size = new Size(73, 15);
            lbl_dob.TabIndex = 1;
            lbl_dob.Text = "Date of Birth";
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Location = new Point(93, 205);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(36, 15);
            lbl_email.TabIndex = 2;
            lbl_email.Text = "email";
            // 
            // tbx_username
            // 
            tbx_username.Location = new Point(184, 151);
            tbx_username.Name = "tbx_username";
            tbx_username.Size = new Size(100, 23);
            tbx_username.TabIndex = 3;
            tbx_username.TextChanged += tbx_username_TextChanged;
            // 
            // tbx_dob
            // 
            tbx_dob.Location = new Point(184, 263);
            tbx_dob.Name = "tbx_dob";
            tbx_dob.Size = new Size(100, 23);
            tbx_dob.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(103, 329);
            button1.Name = "button1";
            button1.Size = new Size(122, 31);
            button1.TabIndex = 5;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbx_email
            // 
            tbx_email.Location = new Point(184, 202);
            tbx_email.Name = "tbx_email";
            tbx_email.Size = new Size(100, 23);
            tbx_email.TabIndex = 6;
            // 
            // reset
            // 
            reset.AutoSize = true;
            reset.Location = new Point(140, 83);
            reset.Name = "reset";
            reset.Size = new Size(85, 15);
            reset.TabIndex = 7;
            reset.Text = "reset password";
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 503);
            Controls.Add(reset);
            Controls.Add(tbx_email);
            Controls.Add(button1);
            Controls.Add(tbx_dob);
            Controls.Add(tbx_username);
            Controls.Add(lbl_email);
            Controls.Add(lbl_dob);
            Controls.Add(lbl_username);
            Name = "ForgotPassword";
            Text = "ForgotPassword";
            Load += ForgotPassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_username;
        private Label lbl_dob;
        private Label lbl_email;
        private TextBox tbx_username;
        private TextBox tbx_dob;
        private Button button1;
        private TextBox tbx_email;
        private Label reset;
    }
}