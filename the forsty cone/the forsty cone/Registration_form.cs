


using Google.Protobuf.WellKnownTypes;
using Microsoft.Data.SqlClient;
using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

//using MySql.Data.MySqlClient;
//sql client import



namespace the_forsty_cone
{
    public partial class Registration_form : Form
    {
        public Registration_form()
        {
            InitializeComponent();


        }



        private void btn_register_Click(object sender, EventArgs e)
        {
           
           
           string stringconnction = "Data Source=ZAK-PC;Initial Catalog='the frosty cone';Integrated Security=True;TrustServerCertificate=True";

            string insertQuery = "INSERT INTO users (username, email, [password]) VALUES (@username, @email, @password)";
            //chnaged password to [password] to avoid sql keyword conflict

            using (SqlConnection con = new SqlConnection(stringconnction))
            {
                try
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@username", tbox_username.Text);
                        cmd.Parameters.AddWithValue("@email", tbox_email.Text);
                        cmd.Parameters.AddWithValue("@password", tbox_password.Text);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Register successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
        }

        private void Registration_form_Load(object sender, EventArgs e)
        {

        }

        private void Registration_form_Load_1(object sender, EventArgs e)
        {

        }
    }

}
