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
    public partial class Userlist : Form
    {



        public Userlist()
        {


            InitializeComponent();
          //  AddToUsers();
            SetupUI();
            // MakeAdmin();
            
        }

        private void listViewusers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Userlist_Load(object sender, EventArgs e)
        {

        }

        private void SetupUI()
        {
            this.Text = "See all users";
            this.Size = new Size(500, 400);
            this.StartPosition = FormStartPosition.CenterParent;

            listViewusers = new ListView();
            listViewusers.View = View.Details;
            listViewusers.FullRowSelect = true;
            listViewusers.GridLines = true;
            listViewusers.Dock = DockStyle.Top;
            listViewusers.Height = 300;

            listViewusers.Columns.Add("id", 200);
            listViewusers.Columns.Add("Users name", 100);
            listViewusers.Columns.Add("Admin", 300);

            this.Controls.Add(listViewusers);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Login m1 = new Login();
            m1.ShowDialog();
        }
    }
}
