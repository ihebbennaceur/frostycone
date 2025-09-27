using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace the_forsty_cone
{
    public partial class Addproducts : Form
     

    {


          Products p1 = new Products();  //tunnel p1
            Database db = new Database();
        public Addproducts()
        {
            InitializeComponent();


        }

        private void Addproducts_Load(object sender, EventArgs e)
        {

        }

        private void btn_adddata_Click(object sender, EventArgs e)
        {




            if (!int.TryParse(tbx_productprice.Text, out int price))
            {
                MessageBox.Show("Please enter a valid numeric price.");
                return;
            }

            p1.ProductName = tbx_productname.Text;
            p1.ProductPrice = price;
            p1.imageurl = tbx_productimage.Text;

            db.addproducts(p1);

            //Products testProduct = new Products
            //{
            //    ProductName = "Test Product",
            //    ProductPrice = 123,
            //    imageurl = "test.jpg"
            //};

            //db.addproducts(testProduct);






        }

        private void tbx_productname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
