namespace the_forsty_cone
{
    partial class Userlist
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
            listViewusers = new ListView();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(203, 396);
            button1.Name = "button1";
            button1.Size = new Size(195, 47);
            button1.TabIndex = 2;
            button1.Text = "btn_close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // listViewusers
            // 
            listViewusers.Location = new Point(650, 498);
            listViewusers.Name = "listViewusers";
            listViewusers.Size = new Size(415, 298);
            listViewusers.TabIndex = 0;
            listViewusers.UseCompatibleStateImageBehavior = false;
            listViewusers.SelectedIndexChanged += listViewusers_SelectedIndexChanged;
            // 
            // Userlist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 827);
            Controls.Add(button1);
            Controls.Add(listViewusers);
            Name = "Userlist";
            Text = "Userlist";
            Load += Userlist_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private ListView listViewusers;
    }
}