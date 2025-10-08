using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace the_forsty_cone
{




    internal class Database
    {
        string stringconnction = "Data Source=ZAK-PC;Initial Catalog='the frosty cone';Integrated Security=True;TrustServerCertificate=True";

        public void addnewuser(Users user)
        {


            // string stringconnction = "Data Source=ZAK-PC;Initial Catalog='the frosty cone';Integrated Security=True;TrustServerCertificate=True";

            string insertQuery = "INSERT INTO users (username, email, [password],DOB,isadmin) VALUES (@username, @email, @password ,@dob,@admin)";


            using (SqlConnection con = new SqlConnection(this.stringconnction))
            {
                try
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@username", user.username);
                        cmd.Parameters.AddWithValue("@email", user.email);
                        cmd.Parameters.AddWithValue("@password", user.password);
                        cmd.Parameters.AddWithValue("@dob", user.DOB);
                        cmd.Parameters.AddWithValue("@admin", user.isAdmin);


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


        public void deleteuser(int id_user)
        {

            string delquery = "DELETE FROM users where id = @id";

            using (SqlConnection con = new SqlConnection(stringconnction))
            {
                try
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(delquery, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id_user);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



                }
                con.Close();
            }
        }

     


        public void addproducts(Products product2)
        {
            //  string stringconnction = "Data Source=ZAK-PC;Initial Catalog='the frosty cone';Integrated Security=True;TrustServerCertificate=True";

            string insertQuery = "INSERT INTO Products (Product_name, Product_price, Product_image) VALUES (@name, @price,@img)";


            using (SqlConnection con = new SqlConnection(this.stringconnction))
            {
                try
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@name", product2.ProductName);
                        cmd.Parameters.AddWithValue("@price", product2.ProductPrice);
                        cmd.Parameters.AddWithValue("@img", product2.imageurl);




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

        public void loginuser(string username1, string password1)
        {
            //int workFactor = 12; // Default is 10
            //string hashedpwd = BCrypt.Net.BCrypt.HashPassword(p1, workFactor); //how to fix?


            //string stringconnction = "Data Source=ZAK-PC;Initial Catalog='the frosty cone';Integrated Security=True;TrustServerCertificate=True";

            string query2 = "select id from users where upper(username) = upper(@username) and password = @password";

            using (SqlConnection con = new SqlConnection(stringconnction))
            {
                try
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(query2, con))
                    {
                        cmd.Parameters.AddWithValue("@username", username1); //change to just .username instead of u1?
                        cmd.Parameters.AddWithValue("@password", password1);

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






        public List<Products> getallProducts()
        {
            string query3 = "SELECT Product_id, Product_name, product_price, Product_image FROM Products";

            List<Products> products_list = new List<Products>();

            using (SqlConnection con = new SqlConnection(stringconnction))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query3, con))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id1 = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                        string name1 = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);

                        // Handle price safely (assuming INT in DB)
                        int price1 = 0;
                        if (!reader.IsDBNull(2))
                        {
                            // if it's int in DB
                            price1 = reader.GetInt32(2);
                            
                        }

                        

                        // Handle image safely
                        string image1 = reader.IsDBNull(3) ? string.Empty : reader["Product_image"].ToString();

                        // Create Product
                        Products p1 = new Products(id1, name1, price1, image1);
                        products_list.Add(p1);
                    }
                }
            }

            return products_list;
        }

        public void deleteproducts(int a)
        {

            string deleteQuery = "DELETE FROM Products WHERE Product_id = @p_id";


            using (SqlConnection con = new SqlConnection(this.stringconnction))
            {
                try
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@p_id", a);



                        cmd.ExecuteNonQuery();

                        MessageBox.Show(" delete successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);


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



