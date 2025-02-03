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
            ColumnHeader columna1 = new ColumnHeader();
            List_View_Friends.Columns.Add(columna1);
            List_View_Friends.Columns[0].Width = 200;
            ColumnHeader columna2 = new ColumnHeader();
            List_View_Friends.Columns.Add(columna2);
            List_View_Friends.Columns[1].Width = 100;
            ColumnHeader columna3 = new ColumnHeader();
            List_View_Friends.Columns.Add(columna3);
            List_View_Friends.Columns[2].Width = 100;

            List_View_Friends.View = View.Details;
            List_View_Friends.HeaderStyle = ColumnHeaderStyle.None;
        }
        public void Open_Form<my_form>(PictureBox menu_button) where my_form : Form, new()
        {
            //Reb un formulari i busca si el nostre panel ya te el formulari.
            //Si ya el te el mostra i si no el te el creara i el mostrara.
            my_form MyForm = Panel_Friends.Controls.OfType<my_form>().FirstOrDefault();

            if (MyForm == null)
            {
                MyForm = new my_form();
                MyForm.TopLevel = false; //Ficara el formulari dins del panel
                MyForm.FormBorderStyle = FormBorderStyle.None;
                MyForm.Dock = DockStyle.Fill;
                Panel_Friends.Controls.Add(MyForm);
                MyForm.Show();
                MyForm.BringToFront();
            }
            else
            {
                MyForm.BringToFront();
            }
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

        public void Add_To_List_Friends(string group_name, string group_description)
        {
            ListViewItem item = new ListViewItem(group_name);
            ListViewItem item_description = new ListViewItem(group_description);

            List_View_Friends.Items.Add(item);

            item.SubItems.Add(group_description);
            item.BackColor = Color.LightBlue;
            item.ForeColor = Color.DarkBlue;
            item.Font = new Font("Arial", 10, FontStyle.Bold);
            foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
            {
                subItem.BackColor = Color.LightCyan;
                subItem.ForeColor = Color.DarkCyan;
            }
        }
    }
}
