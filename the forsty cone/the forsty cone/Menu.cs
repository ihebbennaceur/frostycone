
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace the_forsty_cone
{
    public partial class Menu : Form
    {


        ListView listView;
        ImageList imageList;
        public Menu()
        {
            InitializeComponent();

            
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            loadproducts();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //private void loadproducts()
        //{
        //    listView1.Items.Clear();
        //    imageList = new ImageList();
        //    imageList.ImageSize = new Size(64, 64); // Set the desired image
        //    {

        //        imageList.Images.Add("apple", Image.FromFile("C:/Users/flast/OneDrive/Pictures/Screenshots/Screenshot 2025-10-03 142227.png"));// Set the size of the images

        //        listView1.LargeImageList = imageList;

        //        // 3️⃣ Set the ListView display mode
        //        listView1.View = View.LargeIcon;
        //        listView1.Items.Add(new ListViewItem("Apple", 0));
        //    }
        //    ;






        //    Database db = new Database();
        //    List<Products> products = db.getallProducts();
        //    listView1.View = View.Details;
        //    listView1.FullRowSelect = true;


        //    listView1.Columns.Clear();

        //    listView1.Columns.Add("Product ID", 100);
        //    listView1.Columns.Add("Product Name", 150);
        //    listView1.Columns.Add("Product Price", 100);
        //    listView1.Columns.Add("Image URL", 200);

        //    listView1.Items.Clear();

        //    foreach (Products product in products)
        //    {
        //        ListViewItem item = new ListViewItem(product.ProductId.ToString());

        //        item.SubItems.Add(product.ProductName);
        //        item.SubItems.Add(product.ProductPrice.ToString());
        //        item.SubItems.Add(product.imageurl);

        //        listView1.Items.Add(item);
        //    }
        //}

        private void loadproducts()
        {
            listView1.Clear();
            listView1.View = View.LargeIcon;
            listView1.LargeImageList = new ImageList { ImageSize = new Size(64, 64) };

            Database db = new Database();
            List<Products> products = db.getallProducts();

            int index = 0;
            foreach (Products product in products)
            {
                try
                {
                    // Load image from URL or file path
                    Image img = Image.FromFile(product.imageurl);
                    listView1.LargeImageList.Images.Add(img);

                    // Add item with image
                    var item = new ListViewItem(product.ProductName, index);
                    item.Tag = product; // optional, keep full product object
                    listView1.Items.Add(item);
                    index++;
                }
                catch
                {
                    // Handle missing or bad image
                }
            }
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
              string id = selectedItem.SubItems[0].Text; // Product ID
                string name = selectedItem.SubItems[1].Text; // Product Name
                string price = selectedItem.SubItems[2].Text; // Product Price
                string imgurl = selectedItem.SubItems[3].Text; // Image URL
            }

        }
    }
}

