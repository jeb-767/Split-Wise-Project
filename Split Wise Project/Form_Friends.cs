using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Split_Wise_Project
{
    public partial class Form_Friends : Form
    {
        public Form_Friends()
        {
            InitializeComponent();
            //test
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form new_friend = new Form_NewFriend();
            new_friend.Show();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            PB_New_Friend.Image = Properties.Resources.But_New_Friend_Hold;
        }

        private void PB_New_Friend_MouseLeave(object sender, EventArgs e)
        {
            PB_New_Friend.Image = Properties.Resources.But_New_Friend;
        }
    }
}
