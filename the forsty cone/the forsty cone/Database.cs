using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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


            string insertQuery = "INSERT INTO users (username, email, [password],DOB,isadmin) VALUES (@username, @email, @password ,@dob,@admin)";


            using (SqlConnection con = new SqlConnection(this.stringconnction))
            {
                try //checks for errors
                {
                    con.Open();
                    //adds into database
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
                catch (Exception ex) //checks for errors
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
            //creates a connection to the database
          //  string stringconnction = "Data Source=ZAK-PC;Initial Catalog='the frosty cone';Integrated Security=True;TrustServerCertificate=True"; 

            string insertQuery = "INSERT INTO Products (Product_name, Product_price, Product_image) VALUES (@name, @price,@img)"; 

            using (SqlConnection con = new SqlConnection(this.stringconnction))
            {

                try //checks for errors
                {
                    con.Open();
                    //adds into database
                    using (SqlCommand cmd = new SqlCommand(insertQuery, con)) 
                    {
                        cmd.Parameters.AddWithValue("@name", product2.ProductName); //this line adds the product name to the SQL command
                        cmd.Parameters.AddWithValue("@price", product2.ProductPrice);
                        cmd.Parameters.AddWithValue("@img", product2.imageurl);




                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Register successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }

                }

                catch (Exception ex) //checks for errors
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close(); 

            }
        }

        public bool loginuser(string username, string password)
        {
            try
            {
                string query = @"SELECT id, username, isadmin 
                                 FROM users 
                                 WHERE UPPER(username)=UPPER(@username) 
                                 AND [password]=@password";

                using (SqlConnection con = new SqlConnection(stringconnction))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", username ?? string.Empty);
                        cmd.Parameters.AddWithValue("@password", password ?? string.Empty);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Session.Instance.UserId = reader.GetInt32(0);
                                Session.Instance.Username = reader.GetString(1);
                                Session.Instance.IsAdmin = reader.GetInt32(0);

                                MessageBox.Show("Login successful", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return true;
                            }
                        }
                    }
                }

                MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during login: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
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


        public void RemoveFromBasket(int a,int b) 
        {
            string deleteQuery = "DELETE FROM Basket WHERE id= @u_id  and  Product_id = @p_id";
            using (SqlConnection con = new SqlConnection(this.stringconnction))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                    {
                        cmd.Parameters.AddWithValue("p_id", a);
                        cmd.Parameters.AddWithValue("u_id", b);

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

        public void AddToBasket(int a, int b)
        {
            string ADDQuery = "INSERT INTO Basket WHERE id= @u_id and Product_id = @p_id";
            using (SqlConnection con = new SqlConnection(this.stringconnction))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(ADDQuery, con))
                    {
                        cmd.Parameters.AddWithValue("u_id", a);
                        cmd.Parameters.AddWithValue("u_id", b);
                        
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

        public void AddToUsers(int a, string b, int c)
        {
            string ADDQuery2 = "SELECT id, username, isadmin FROM users";


            using (SqlConnection con = new SqlConnection(this.stringconnction))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(ADDQuery2, con))
                    {
                        cmd.Parameters.AddWithValue("u_id", a);
                        cmd.Parameters.AddWithValue("u_username", b);
                        cmd.Parameters.AddWithValue("u_isadmin", c);

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


        bool checkEmailExist(string email)
        {
            string query = "select count(*) from users where email=@email";
            int count = 0;
            using (SqlConnection con = new SqlConnection(this.stringconnction))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        count = (int)cmd.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void resetpassword(string email, string username, string dob)
        {
            if (checkEmailExist(email) == true)
            {


                try
                {
                    string query = @"SELECT username, dob 
                          FROM users 
                          WHERE UPPER(username)=UPPER(@username) 
                          AND [dob]=@dob";

                    using (SqlConnection con = new SqlConnection(stringconnction))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@username", username ?? string.Empty);
                            cmd.Parameters.AddWithValue("@dob", dob ?? string.Empty);

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {

                                    Session.Instance.Username = reader.GetString(1);


                                    Newpwd n1 = new Newpwd();
                                }
                                else
                                {
                                    MessageBox.Show("Wrong information", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                    }


                }


                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


     
            
                        
            



                }
            }
        }

        public void MakeAdmin(int id, int isadmin)
        {
            string ADDQuery2 = "SELECT id, isadmin FROM users";


            using (SqlConnection con = new SqlConnection(this.stringconnction))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(ADDQuery2, con))
                    {
                        cmd.Parameters.AddWithValue("u_id", id);
                        cmd.Parameters.AddWithValue("u_isadmin", isadmin);
                        cmd.Parameters.AddWithValue("@isadmin", 1); 
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

    }
}



