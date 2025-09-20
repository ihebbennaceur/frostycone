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
    public partial class Frontpage : Form
    {
        public Frontpage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu m1 = new Menu();
            m1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registration_form m1 = new Registration_form();
            m1.ShowDialog();
        }
    }
}
