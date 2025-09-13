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
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(40, 145);
            button1.Name = "button1";
            button1.Size = new Size(428, 72);
            button1.TabIndex = 0;
            button1.Text = "See menu ";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(222, 67);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 1;
            label1.Text = "Welcome";
            // 
            // button2
            // 
            button2.Location = new Point(357, 38);
            button2.Name = "button2";
            button2.Size = new Size(136, 72);
            button2.TabIndex = 2;
            button2.Text = "Login/register";
            button2.UseVisualStyleBackColor = true;
            // 
            // Frontpage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 638);
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