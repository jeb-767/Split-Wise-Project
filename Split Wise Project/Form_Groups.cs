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
    public partial class Form_Groups : Form
    {
        public Form_Groups()
        {
            InitializeComponent();
            ColumnHeader columna1 = new ColumnHeader();
            List_View_Groups.Columns.Add(columna1);
            List_View_Groups.View = View.Details;
            List_View_Groups.HeaderStyle = ColumnHeaderStyle.None;
        }

        private void But_New_Group_Click(object sender, EventArgs e)
        {
            Form new_group = new Form_NewGroup();
            new_group.Show();
        }

        private void But_New_Group_MouseEnter(object sender, EventArgs e)
        {
            But_New_Group.Image = Properties.Resources.But_New_Group_Hold;
        }

        private void But_New_Group_MouseLeave(object sender, EventArgs e)
        {
            But_New_Group.Image = Properties.Resources.But_New_Group;
        }

        public void Add_To_List_Groups(string group_name)
        {
            ListViewItem item = new ListViewItem(group_name);
            List_View_Groups.Items.Add(item);
        }
    }
}
