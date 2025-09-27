namespace the_forsty_cone
{
    partial class Addproducts
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
            btn_addproduct = new Button();
            tbx_productname = new TextBox();
            label2 = new Label();
            label3 = new Label();
            tbx_productprice = new TextBox();
            label4 = new Label();
            tbx_productimage = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(257, 109);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Add products";
            // 
            // btn_addproduct
            // 
            btn_addproduct.Location = new Point(369, 249);
            btn_addproduct.Name = "btn_addproduct";
            btn_addproduct.Size = new Size(106, 61);
            btn_addproduct.TabIndex = 1;
            btn_addproduct.Text = "Add product";
            btn_addproduct.UseVisualStyleBackColor = true;
            btn_addproduct.Click += btn_adddata_Click;
            // 
            // tbx_productname
            // 
            tbx_productname.Location = new Point(208, 229);
            tbx_productname.Name = "tbx_productname";
            tbx_productname.Size = new Size(100, 23);
            tbx_productname.TabIndex = 2;
            tbx_productname.TextChanged += tbx_productname_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 232);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 3;
            label2.Text = "name of product";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 272);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 5;
            label3.Text = "price of product";
            // 
            // tbx_productprice
            // 
            tbx_productprice.Location = new Point(208, 269);
            tbx_productprice.Name = "tbx_productprice";
            tbx_productprice.Size = new Size(100, 23);
            tbx_productprice.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 313);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 7;
            label4.Text = "image url";
            // 
            // tbx_productimage
            // 
            tbx_productimage.Location = new Point(208, 310);
            tbx_productimage.Name = "tbx_productimage";
            tbx_productimage.Size = new Size(100, 23);
            tbx_productimage.TabIndex = 6;
            // 
            // Addproducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 512);
            Controls.Add(label4);
            Controls.Add(tbx_productimage);
            Controls.Add(label3);
            Controls.Add(tbx_productprice);
            Controls.Add(label2);
            Controls.Add(tbx_productname);
            Controls.Add(btn_addproduct);
            Controls.Add(label1);
            Name = "Addproducts";
            Text = "Addproducts";
            Load += Addproducts_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_addproduct;
        private TextBox tbx_productname;
        private Label label2;
        private Label label3;
        private TextBox tbx_productprice;
        private Label label4;
        private TextBox tbx_productimage;
    }
}