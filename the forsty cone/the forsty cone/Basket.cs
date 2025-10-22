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
    public partial class Basket : Form
    {

        private List<Products> _basketItems;
        private ListView listViewBasket;
        private Button btnClose;
        private Label lblTotal;

        public Basket(List<Products> basketItems)
        {
            InitializeComponent();
            _basketItems = basketItems ?? new List<Products>();
            SetupUI();
            LoadBasketItems();
           
        }
        private void SetupUI()
        {
            this.Text = " Your Basket";
            this.Size = new Size(500, 400);
            this.StartPosition = FormStartPosition.CenterParent;

            listViewBasket = new ListView();
            listViewBasket.View = View.Details;
            listViewBasket.FullRowSelect = true;
            listViewBasket.GridLines = true;
            listViewBasket.Dock = DockStyle.Top;
            listViewBasket.Height = 300;

            listViewBasket.Columns.Add("Product Name", 200);
            listViewBasket.Columns.Add("Price", 100);

            lblTotal = new Label();
            lblTotal.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblTotal.Text = "Total: $0.00";
            lblTotal.Dock = DockStyle.Top;
            lblTotal.Height = 30;
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;

            btnClose = new Button();
            btnClose.Text = "Close";
            btnClose.Dock = DockStyle.Bottom;
            btnClose.Height = 40;
            btnClose.Click += (s, e) => this.Close();

            this.Controls.Add(btnClose);
            this.Controls.Add(lblTotal);
            this.Controls.Add(listViewBasket);
        }

        private void LoadBasketItems()
        {
            listViewBasket.Items.Clear();
            decimal total = 0;

            foreach (var product in _basketItems)
            {
                var item = new ListViewItem(product.ProductName);
                item.SubItems.Add($"{product.ProductPrice:C}");
                listViewBasket.Items.Add(item);
                total += product.ProductPrice;
            }

            lblTotal.Text = $" Total: {total:C}";
        }


        public void updatebasket(List<Products> newBasketItems)
        {
            _basketItems = newBasketItems ?? new List<Products>();
            LoadBasketItems();
        }

        private void Basket_Load(object sender, EventArgs e)
        {
           
        }

    }
}
           