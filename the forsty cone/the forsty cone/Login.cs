    using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

                string stringconnction = "Data Source=ZAK-PC;Initial Catalog='the frosty cone';Integrated Security=True;TrustServerCertificate=True";

                string query2 = "select id from users where upper(username) = upper(@username) and password = @password";

                using (SqlConnection con = new SqlConnection(stringconnction))
                {
                    try
                    {
                        con.Open();

                        using (SqlCommand cmd = new SqlCommand(query2, con))
                        {
                            cmd.Parameters.AddWithValue("@username", tb_username.Text);
                            cmd.Parameters.AddWithValue("@password", tb_password.Text);

                            cmd.ExecuteNonQuery();
                            int rez = 0;
                            if (cmd.Parameters.Count > 0)
                            {
                                rez = (int)cmd.ExecuteScalar();

                            }

                            MessageBox.Show("login successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }





                        //check with database
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }


    }
}
