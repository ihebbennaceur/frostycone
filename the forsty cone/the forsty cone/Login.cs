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
    public partial class Login : Form

    {


        public Login()
        {
            InitializeComponent();
            
        }






        private void btn_login_Click(object sender, EventArgs e)
        {
            if (tb_username.Text != null && tb_password.Text != null)
            {

                string u1 = tb_username.Text;
                string p1 = tb_password.Text;



                //check with database
            }
            else
            {
                MessageBox.Show("Please enter username and password", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }


    }
}
