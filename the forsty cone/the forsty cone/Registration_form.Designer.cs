using System.Data.SqlClient;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace the_forsty_cone
{
    partial class Registration_form
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
            btn_register = new Button();
            tbox_password = new TextBox();
            lbl_username = new Label();
            lbl_password = new Label();
            lbl_confirmPassword = new Label();
            tbox_email = new TextBox();
            tbox_confirmpassword = new TextBox();
            lbl_email = new Label();
            tbox_username = new TextBox();
            SuspendLayout();
            // 
            // btn_register
            // 
            btn_register.Location = new Point(139, 305);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(75, 23);
            btn_register.TabIndex = 0;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // tbox_password
            // 
            tbox_password.Location = new Point(205, 168);
            tbox_password.Name = "tbox_password";
            tbox_password.Size = new Size(100, 23);
            tbox_password.TabIndex = 2;
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Location = new Point(85, 132);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(60, 15);
            lbl_username.TabIndex = 3;
            lbl_username.Text = "Username";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Location = new Point(85, 171);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(57, 15);
            lbl_password.TabIndex = 4;
            lbl_password.Text = "Password";
            // 
            // lbl_confirmPassword
            // 
            lbl_confirmPassword.AutoSize = true;
            lbl_confirmPassword.Location = new Point(85, 206);
            lbl_confirmPassword.Name = "lbl_confirmPassword";
            lbl_confirmPassword.Size = new Size(104, 15);
            lbl_confirmPassword.TabIndex = 5;
            lbl_confirmPassword.Text = "Confirm Password";
            // 
            // tbox_email
            // 
            tbox_email.Location = new Point(205, 240);
            tbox_email.Name = "tbox_email";
            tbox_email.Size = new Size(100, 23);
            tbox_email.TabIndex = 6;
            // 
            // tbox_confirmpassword
            // 
            tbox_confirmpassword.Location = new Point(205, 203);
            tbox_confirmpassword.Name = "tbox_confirmpassword";
            tbox_confirmpassword.Size = new Size(100, 23);
            tbox_confirmpassword.TabIndex = 7;
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Location = new Point(85, 243);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(36, 15);
            lbl_email.TabIndex = 8;
            lbl_email.Text = "Email";
            // 
            // tbox_username
            // 
            tbox_username.Location = new Point(205, 129);
            tbox_username.Name = "tbox_username";
            tbox_username.Size = new Size(100, 23);
            tbox_username.TabIndex = 9;
            // 
            // Registration_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_email);
            Controls.Add(tbox_confirmpassword);
            Controls.Add(tbox_email);
            Controls.Add(lbl_confirmPassword);
            Controls.Add(lbl_password);
            Controls.Add(lbl_username);
            Controls.Add(tbox_password);
            Controls.Add(tbox_username);
            Controls.Add(btn_register);
            Name = "Registration_form";
            Text = "Registration_form";
            Load += Registration_form_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_register;
        private TextBox tbox_password;
        private Label lbl_username;
        private Label lbl_password;
        private Label lbl_confirmPassword;
        private TextBox tbox_email;
        private TextBox tbox_confirmpassword;
        private Label lbl_email;
        private TextBox tbox_username;
    }
}




 
