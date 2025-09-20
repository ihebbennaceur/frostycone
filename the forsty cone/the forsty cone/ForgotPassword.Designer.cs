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
            label1 = new Label();
            tbox_pass = new TextBox();
            tbox_confirmpass = new TextBox();
            btn_reset = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(135, 138);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 0;
            label1.Text = "Reset Password:";
            // 
            // tbox_pass
            // 
            tbox_pass.Location = new Point(175, 239);
            tbox_pass.Name = "tbox_pass";
            tbox_pass.Size = new Size(100, 23);
            tbox_pass.TabIndex = 1;
            // 
            // tbox_confirmpass
            // 
            tbox_confirmpass.Location = new Point(175, 294);
            tbox_confirmpass.Name = "tbox_confirmpass";
            tbox_confirmpass.Size = new Size(100, 23);
            tbox_confirmpass.TabIndex = 2;
            // 
            // btn_reset
            // 
            btn_reset.Location = new Point(122, 356);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(75, 23);
            btn_reset.TabIndex = 3;
            btn_reset.Text = "Reset";
            btn_reset.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 242);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 4;
            label2.Text = "Enter Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 302);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 5;
            label3.Text = "Confirm Password";
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 503);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn_reset);
            Controls.Add(tbox_confirmpass);
            Controls.Add(tbox_pass);
            Controls.Add(label1);
            Name = "ForgotPassword";
            Text = "ForgotPassword";
            Load += ForgotPassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbox_pass;
        private TextBox tbox_confirmpass;
        private Button btn_reset;
        private Label label2;
        private Label label3;
    }
}