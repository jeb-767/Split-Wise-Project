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
    public partial class Group_View : Form
    {
        public Group_View()
        {
            InitializeComponent();
        }

        private void PB_New_Gast_MouseEnter(object sender, EventArgs e)
        {
            PB_New_Gast.Image = Properties.Resources.But_New_Gast_Hold;
        }

        private void PB_New_Gast_MouseLeave(object sender, EventArgs e)
        {
            PB_New_Gast.Image = Properties.Resources.But_New_Gast;
        }

        private void PB_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PB_New_Gast_Click(object sender, EventArgs e)
        {
            Form new_group = new Form_New_Gast();
            new_group.Show();
        }

        private void PB_Back_MouseEnter(object sender, EventArgs e)
        {
            PB_Back.Image = Properties.Resources.But_Back_Hold;
        }

        private void PB_Back_MouseLeave(object sender, EventArgs e)
        {
            PB_Back.Image = Properties.Resources.But_Back;
        }
    }
}
