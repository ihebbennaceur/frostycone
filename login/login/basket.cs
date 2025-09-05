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
    public partial class basket : Form
    {
        public basket()
        {
            InitializeComponent();
        }

        private void basket_Load(object sender, EventArgs e)
        {

            int n = 0;
            lbl_display.Text = "";

            foreach (var tuple in global_class.items)
            {

                foreach (var i in global_class.items)
                {

                    if (tuple.Item1 == tuple.Item1 && tuple.Item2 == tuple.Item2 && tuple.Item3 == tuple.Item3)
                    {

                        n = n + 1;

                        lbl_increase.Text = n.ToString();

                    }

                    lbl_display.Text += "\nproduct: " + tuple.Item1.ToString() + "                    price: £" + tuple.Item2.ToString() + "                   no. of scoops: " + tuple.Item3.ToString();


                }
            }

            //if the product is the exact same, instead of reprinting put a quantity icon showing how much.
         // if (global_class.items.product_name)
          //  {

         //   }
        }
    }
}
