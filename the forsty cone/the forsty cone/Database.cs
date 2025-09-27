using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace the_forsty_cone
{
    internal class Database
    {
        public void addnewuser(Users user)
        {


            string stringconnction = "Data Source=ZAK-PC;Initial Catalog='the frosty cone';Integrated Security=True;TrustServerCertificate=True";

            string insertQuery = "INSERT INTO users (username, email, [password]) VALUES (@username, @email, @password)";


            using (SqlConnection con = new SqlConnection(stringconnction))
            {
                try
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@username", user.username);
                        cmd.Parameters.AddWithValue("@email", user.email);
                        cmd.Parameters.AddWithValue("@password", user.password);

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
        
        public void addproducts(Products product)
        {
            string stringconnction = "Data Source=ZAK-PC;Initial Catalog='the frosty cone';Integrated Security=True;TrustServerCertificate=True";

            string insertQuery ="INSERT INTO Products (Product_name, Product_price, Product_image) VALUES (@name, @price,@img)";
             

            using (SqlConnection con = new SqlConnection(stringconnction))
            {
                try
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@name", product.ProductName);
                        cmd.Parameters.AddWithValue("@price", product.ProductPrice);
                        cmd.Parameters.AddWithValue("@img", product.imageurl); 
                      
                       


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
    }

    
}



