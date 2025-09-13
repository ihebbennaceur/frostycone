namespace the_forsty_cone
{
    partial class Basket
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 21);
            button1.Name = "button1";
            button1.Size = new Size(90, 72);
            button1.TabIndex = 0;
            button1.Text = "< back to menu";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 50);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 1;
            label1.Text = "Basket";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 155);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 2;
            label2.Text = "Items";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(242, 155);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 3;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(135, 155);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 4;
            label4.Text = "quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 393);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 5;
            label5.Text = "total";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(244, 393);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 6;
            label6.Text = "total";
            // 
            // button2
            // 
            button2.Location = new Point(22, 475);
            button2.Name = "button2";
            button2.Size = new Size(280, 65);
            button2.TabIndex = 7;
            button2.Text = "Place Order";
            button2.UseVisualStyleBackColor = true;
            // 
            // Basket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 610);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Basket";
            Text = "Basket";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button2;
    }
}