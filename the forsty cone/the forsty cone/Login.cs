using BCrypt.Net;
using Google.Protobuf.WellKnownTypes;
    using Microsoft.Data.SqlClient;
using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
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

                int workFactor = 12; // Default is 10
                string hashedpwd = BCrypt.Net.BCrypt.HashPassword(p1, workFactor);


                // string hashedpwd = BCrypt.Net.BCrypt.HashPassword(p1);

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
                            cmd.Parameters.AddWithValue("@password", hashedpwd);

                            cmd.ExecuteNonQuery();
                            int result = 0;
                            if (cmd.Parameters.Count > 0)
                            {
                                result = (int)cmd.ExecuteScalar();

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

        private void btn_createaccount_Click(object sender, EventArgs e)
        {
            Registration_form m1 = new Registration_form();
            m1.ShowDialog();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Frontpage m1 = new Frontpage();
            m1.ShowDialog();
        }

        private void btn_forgotpassword_Click(object sender, EventArgs e)
        {
            ForgotPassword m1 = new ForgotPassword();
            m1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Addproducts a1  = new Addproducts();
            a1.ShowDialog();
            
        }
    }
}
