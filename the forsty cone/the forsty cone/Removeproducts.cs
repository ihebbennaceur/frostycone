using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace the_forsty_cone
{
    public partial class Removeproducts : Form
    {

        

        public Removeproducts()
        {
            InitializeComponent();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            

            if (!int.TryParse(tbx_proid.Text, out int id))  //control check for the input type
            {
                MessageBox.Show("Please enter a valid id.");
                return;
            }


            Database db1 = new Database();
            db1.deleteproducts(id);
           
        }
        

        private void Removeproducts_Load(object sender, EventArgs e)
        {

        }
    }
}
