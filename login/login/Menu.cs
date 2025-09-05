using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Products_list  m1 = new Products_list();
            m1.ShowDialog();
        }

        private void Seeflavours2_Click(object sender, EventArgs e)
        {
            Products_list m1 = new Products_list();
            m1.ShowDialog();
        }
    }
}
