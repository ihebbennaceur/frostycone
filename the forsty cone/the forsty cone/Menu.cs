
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

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

        //    // Setup ImageList for displaying images
        //    imageList = new ImageList();
        //    imageList.ImageSize = new Size(64, 64); // Set the desired image size
        //    listView1.LargeImageList = imageList; // For LargeIcon view
        //    listView1.SmallImageList = imageList; // For Details view

        //    // Set ListView properties
        //    listView1.View = View.Details;
        //    listView1.FullRowSelect = true;
        //    listView1.GridLines = true;

        //    // Define columns
        //    listView1.Columns.Clear();
        //    listView1.Columns.Add("Product ID", 100);
        //    listView1.Columns.Add("Product Name", 150);
        //    listView1.Columns.Add("Product Price", 100);
        //    listView1.Columns.Add("Image", 200); // This will show the image, not URL

        //    Database db = new Database();
        //    List<Products> products = db.getallProducts();

        //    int imageIndex = 0;

        //    foreach (Products product in products)
        //    {
        //        try
        //        {
        //            // Load image from the URL/path
        //            Image productImage = Image.FromFile(product.imageurl);
        //            imageList.Images.Add(productImage);

        //            // Create ListViewItem with image
        //            ListViewItem item = new ListViewItem(product.ProductId.ToString(), imageIndex);
        //            item.SubItems.Add(product.ProductName);
        //            item.SubItems.Add(product.ProductPrice.ToString());
        //            item.SubItems.Add(""); // Empty text for image column, image will show in first column

        //            listView1.Items.Add(item);
        //            imageIndex++;
        //        }
        //        catch (Exception ex)
        //        {
        //            // If image fails to load, use a default image or continue without image
        //            Console.WriteLine($"Error loading image for {product.ProductName}: {ex.Message}");

        //            // Add item without image
        //            ListViewItem item = new ListViewItem(product.ProductId.ToString());
        //            item.SubItems.Add(product.ProductName);
        //            item.SubItems.Add(product.ProductPrice.ToString());
        //            item.SubItems.Add("Image not available");

        //            listView1.Items.Add(item);
        //        }
        //    }
        //}

        //private void loadproducts()
        //{
        //    listView1.Items.Clear();
        //    imageList = new ImageList();
        //    imageList.ImageSize = new Size(64, 64); // Set the desired image
        //    {

        //        //     imageList.Images.Add("apple", Image.FromFile("C:/Users/flast/OneDrive/Pictures/Screenshots/Screenshot 2025-10-03 142227.png"));// Set the size of the images

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
            listView1.Items.Clear();

            // Setup ImageList
            imageList = new ImageList();
            imageList.ImageSize = new Size(64, 64);
            listView1.SmallImageList = imageList;
            listView1.LargeImageList = imageList;

            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            // Define columns
            listView1.Columns.Clear();
            listView1.Columns.Add("Image", 80);
            listView1.Columns.Add("Product ID", 100);
            listView1.Columns.Add("Product Name", 150);
            listView1.Columns.Add("Product Price", 100);


            Database db = new Database();
            List<Products> products = db.getallProducts();

            int imageIndex = 0;

            foreach (Products product in products)
            {
                try
                {
                    // Clean the path - remove quotes and trim
                    string cleanPath = CleanImagePath(product.imageurl);

                    Console.WriteLine($"Trying to load: {cleanPath}");
                    Console.WriteLine($"File exists: {File.Exists(cleanPath)}");

                    if (File.Exists(cleanPath))
                    {
                        Image productImage = LoadImage(cleanPath);
                        if (productImage != null)
                        {
                            imageList.Images.Add(productImage);

                            ListViewItem item = new ListViewItem("", imageIndex);
                            item.SubItems.Add(product.ProductId.ToString());
                            item.SubItems.Add(product.ProductName);
                            item.SubItems.Add(product.ProductPrice.ToString("C"));



                            listView1.Items.Add(item);

                            imageIndex++;
                            Console.WriteLine($"Successfully loaded image for {product.ProductName}");
                        }
                        else
                        {
                            AddItemWithoutImage(product, "Invalid image");
                        }
                    }
                    else
                    {
                        AddItemWithoutImage(product, "File not found");
                    }
                }
                catch (Exception ex)
                {
                    AddItemWithoutImage(product, $"Error: {ex.Message}");
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        private string CleanImagePath(string path)
        {
            if (string.IsNullOrEmpty(path)) return path;

            // Remove quotes and trim
            string cleanPath = path.Replace("\"", "").Trim();

            // Fix path separators if needed
            cleanPath = cleanPath.Replace('/', '\\');

            return cleanPath;
        }

        private Image LoadImage(string filePath)
        {
            try
            {
                // For .webp files, we might need special handling
                string extension = Path.GetExtension(filePath).ToLower();

                if (extension == ".webp")
                {
                    // Try using Image.FromFile first
                    try
                    {
                        return Image.FromFile(filePath);
                    }
                    catch
                    {
                        // If .webp fails, try to convert or use a fallback
                        return HandleWebPImage(filePath);
                    }
                }
                else
                {
                    // For other image formats
                    return Image.FromFile(filePath);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading image {filePath}: {ex.Message}");
                return null;
            }
        }

        private Image HandleWebPImage(string filePath)
        {
            // Option 1: Use a placeholder image for .webp files
            try
            {
                // Create a simple placeholder bitmap
                Bitmap placeholder = new Bitmap(64, 64);
                using (Graphics g = Graphics.FromImage(placeholder))
                {
                    g.Clear(Color.LightGray);
                    using (Font font = new Font("Arial", 8))
                    {
                        g.DrawString("WEBP", font, Brushes.Black, new PointF(5, 25));
                    }
                }
                return placeholder;
            }
            catch
            {
                return null;
            }
        }

        private void AddItemWithoutImage(Products product, string status)
        {
            ListViewItem item = new ListViewItem(status);
            item.SubItems.Add(product.ProductId.ToString());
            item.SubItems.Add(product.ProductName);
            item.SubItems.Add(product.ProductPrice.ToString("C"));
            listView1.Items.Add(item);
            Console.WriteLine($"Added without image: {product.ProductName} - {status}");
        }




        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (listView1.SelectedItems.Count > 0)
            {


                string name = "";
                string imgurl = "";
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string id = selectedItem.SubItems[0].Text; // Product ID
                name = selectedItem.SubItems[1].Text; // Product Name
                string price = selectedItem.SubItems[2].Text; // Product Price
                imgurl = selectedItem.SubItems[3].Text; // Image URL


                //Products p1 = new Products
                //{
                //    ProductId = int.Parse(id),
                //    ProductName = name,
                //    ProductPrice = int.Parse(price),
                //    imageurl = "rnadom"
                //};

                //box.Add(p1);


            }
        }


        List<Products> box = new List<Products>();
        private void btnAddToCart_Click(object sender, EventArgs e)

        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a product first!");
                return;
            }

            ListViewItem selectedItem = listView1.SelectedItems[0];

            // ⚠️ adapte les index selon tes colonnes
            string name = selectedItem.SubItems[2].Text;
            string priceText = selectedItem.SubItems[3].Text.Replace("£", "").Trim();

            if (!decimal.TryParse(priceText, out decimal price))
            {
                MessageBox.Show("Invalid price format.");
                return;
            }

            // Ajouter dans le panier
            Products p = new Products { ProductName = name, ProductPrice = (int)price };
            box.Add(p);


        }



        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select an item in the cart to remove.");
                return;
            }

            int index = listView1.SelectedItems[0].Index;
            box.RemoveAt(index);


        }


        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            btnAddToCart_Click(sender, e);
        }
    }
}

