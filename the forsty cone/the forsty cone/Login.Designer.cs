namespace the_forsty_cone
{
    partial class Login
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
            btn_login = new Button();
            lbl_username = new Label();
            tb_username = new TextBox();
            tb_password = new TextBox();
            lbl_password = new Label();
            btn_forgotpassword = new Button();
            lbl_displayerror = new Label();
            btn_createaccount = new Button();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.Location = new Point(88, 309);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(164, 23);
            btn_login.TabIndex = 0;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Location = new Point(88, 159);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(59, 15);
            lbl_username.TabIndex = 1;
            lbl_username.Text = "username";
            // 
            // tb_username
            // 
            tb_username.Location = new Point(88, 186);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(164, 23);
            tb_username.TabIndex = 2;
            // 
            // tb_password
            // 
            tb_password.Location = new Point(88, 252);
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(164, 23);
            tb_password.TabIndex = 4;
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Location = new Point(88, 225);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(57, 15);
            lbl_password.TabIndex = 3;
            lbl_password.Text = "Password";
            // 
            // btn_forgotpassword
            // 
            btn_forgotpassword.Location = new Point(88, 371);
            btn_forgotpassword.Name = "btn_forgotpassword";
            btn_forgotpassword.Size = new Size(164, 23);
            btn_forgotpassword.TabIndex = 5;
            btn_forgotpassword.Text = "Forgot Password";
            btn_forgotpassword.UseVisualStyleBackColor = true;
            // 
            // lbl_displayerror
            // 
            lbl_displayerror.AutoSize = true;
            lbl_displayerror.Location = new Point(88, 344);
            lbl_displayerror.Name = "lbl_displayerror";
            lbl_displayerror.Size = new Size(176, 15);
            lbl_displayerror.TabIndex = 6;
            lbl_displayerror.Text = "username or password incorrect";
            // 
            // btn_createaccount
            // 
            btn_createaccount.Location = new Point(88, 427);
            btn_createaccount.Name = "btn_createaccount";
            btn_createaccount.Size = new Size(164, 23);
            btn_createaccount.TabIndex = 7;
            btn_createaccount.Text = "create account";
            btn_createaccount.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 593);
            Controls.Add(btn_createaccount);
            Controls.Add(lbl_displayerror);
            Controls.Add(btn_forgotpassword);
            Controls.Add(tb_password);
            Controls.Add(lbl_password);
            Controls.Add(tb_username);
            Controls.Add(lbl_username);
            Controls.Add(btn_login);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_login;
        private Label lbl_username;
        private TextBox tb_username;
        private TextBox tb_password;
        private Label lbl_password;
        private Button btn_forgotpassword;
        private Label lbl_displayerror;
        private Button btn_createaccount;
    }
}