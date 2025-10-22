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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btn_login = new Button();
            tb_username = new TextBox();
            tb_password = new TextBox();
            btn_forgotpassword = new Button();
            btn_createaccount = new Button();
            btn_back = new Button();
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.BackColor = SystemColors.ActiveCaptionText;
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Segoe UI", 11F);
            btn_login.ForeColor = SystemColors.ControlLightLight;
            btn_login.Location = new Point(130, 348);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(245, 29);
            btn_login.TabIndex = 0;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // tb_username
            // 
            tb_username.BackColor = SystemColors.ControlLightLight;
            tb_username.Location = new Point(130, 249);
            tb_username.Name = "tb_username";
            tb_username.PlaceholderText = "Username";
            tb_username.Size = new Size(237, 23);
            tb_username.TabIndex = 2;
            tb_username.TextChanged += tb_username_TextChanged;
            // 
            // tb_password
            // 
            tb_password.BackColor = SystemColors.HighlightText;
            tb_password.Location = new Point(130, 303);
            tb_password.Name = "tb_password";
            tb_password.PasswordChar = '*';
            tb_password.PlaceholderText = "Password";
            tb_password.Size = new Size(243, 23);
            tb_password.TabIndex = 4;
            // 
            // btn_forgotpassword
            // 
            btn_forgotpassword.BackColor = SystemColors.ActiveCaptionText;
            btn_forgotpassword.BackgroundImageLayout = ImageLayout.None;
            btn_forgotpassword.FlatAppearance.BorderColor = Color.Black;
            btn_forgotpassword.FlatStyle = FlatStyle.Flat;
            btn_forgotpassword.Font = new Font("Segoe UI", 11F);
            btn_forgotpassword.ForeColor = SystemColors.ControlLightLight;
            btn_forgotpassword.Location = new Point(136, 416);
            btn_forgotpassword.Name = "btn_forgotpassword";
            btn_forgotpassword.Size = new Size(237, 30);
            btn_forgotpassword.TabIndex = 5;
            btn_forgotpassword.Text = "Forgot Password";
            btn_forgotpassword.UseVisualStyleBackColor = false;
            btn_forgotpassword.Click += btn_forgotpassword_Click;
            // 
            // btn_createaccount
            // 
            btn_createaccount.BackColor = Color.Black;
            btn_createaccount.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 64);
            btn_createaccount.FlatStyle = FlatStyle.Flat;
            btn_createaccount.Font = new Font("Segoe UI", 11F);
            btn_createaccount.ForeColor = SystemColors.ButtonHighlight;
            btn_createaccount.Location = new Point(137, 489);
            btn_createaccount.Name = "btn_createaccount";
            btn_createaccount.Size = new Size(242, 32);
            btn_createaccount.TabIndex = 7;
            btn_createaccount.Text = "create account";
            btn_createaccount.UseVisualStyleBackColor = false;
            btn_createaccount.Click += btn_createaccount_Click;
            // 
            // btn_back
            // 
            btn_back.BackColor = SystemColors.ButtonHighlight;
            btn_back.Location = new Point(319, 82);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(60, 46);
            btn_back.TabIndex = 8;
            btn_back.Text = "home";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // button1
            // 
            button1.Location = new Point(652, 310);
            button1.Name = "button1";
            button1.Size = new Size(93, 50);
            button1.TabIndex = 9;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(136, 466);
            label1.Name = "label1";
            label1.Size = new Size(131, 15);
            label1.TabIndex = 10;
            label1.Text = "Don't have an account?";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(127, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(260, 498);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(652, 366);
            button2.Name = "button2";
            button2.Size = new Size(93, 50);
            button2.TabIndex = 12;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(137, 78);
            button3.Name = "button3";
            button3.Size = new Size(93, 50);
            button3.TabIndex = 13;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(836, 617);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btn_back);
            Controls.Add(btn_createaccount);
            Controls.Add(btn_forgotpassword);
            Controls.Add(tb_password);
            Controls.Add(tb_username);
            Controls.Add(btn_login);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = " ";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_login;
        private TextBox tb_username;
        private TextBox tb_password;
        private Button btn_forgotpassword;
        private Button btn_createaccount;
        private Button btn_back;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button2;
        private Button button3;
    }
}