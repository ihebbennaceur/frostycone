using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Products_list : Form
    {
        public Products_list()
        {
            InitializeComponent();
        }

        private void Products_list_Load(object sender, EventArgs e)
        {
            
    
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            basket m1 = new basket();
            m1.ShowDialog();
        }

        private void button_minus1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btn_add1_Click(object sender, EventArgs e)
        {
            string product_name = "chocolate";
            double price = 5.99;
            int scoops = 1;

            global_class.items.Add(Tuple.Create(product_name, price, scoops ));

            

        }

        private void btn_add2_Click(object sender, EventArgs e)
        {
            string product_name = "cookie dough";
            double price = 6.99;
            int scoops = 1;

            global_class.items.Add(Tuple.Create(product_name, price, scoops));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
