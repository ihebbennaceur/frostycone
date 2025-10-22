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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Addproducts a1 = new Addproducts();
            a1.ShowDialog();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            Removeproducts a1 = new Removeproducts();
            a1.ShowDialog();
        }

        private void btn_seeuserlist_Click(object sender, EventArgs e)
        {
            Userlist a1 = new Userlist();
            a1.ShowDialog();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
