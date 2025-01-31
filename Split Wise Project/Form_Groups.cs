using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Split_Wise_Project
{
    public partial class Form_Groups : Form
    {
        public Form_Groups()
        {
            InitializeComponent();
            ColumnHeader columna1 = new ColumnHeader();
            List_View_Groups.Columns.Add(columna1);
            List_View_Groups.Columns[0].Width = 200;
            ColumnHeader columna2 = new ColumnHeader();
            List_View_Groups.Columns.Add(columna2);
            List_View_Groups.Columns[1].Width = 100;
            ColumnHeader columna3 = new ColumnHeader();
            List_View_Groups.Columns.Add(columna3);
            List_View_Groups.Columns[2].Width = 100;

            List_View_Groups.View = View.Details;
            List_View_Groups.HeaderStyle = ColumnHeaderStyle.None;

        }


        public void Open_Form<my_form>(PictureBox menu_button) where my_form : Form, new()
        {
            //Reb un formulari i busca si el nostre panel ya te el formulari.
            //Si ya el te el mostra i si no el te el creara i el mostrara.
            my_form MyForm = PanelGroups.Controls.OfType<my_form>().FirstOrDefault();

            if (MyForm == null)
            {
                MyForm = new my_form();
                MyForm.TopLevel = false; //Ficara el formulari dins del panel
                MyForm.FormBorderStyle = FormBorderStyle.None;
                MyForm.Dock = DockStyle.Fill;
                PanelGroups.Controls.Add(MyForm);
                MyForm.Show();
                MyForm.BringToFront();
            }
            else
            {
                MyForm.BringToFront();
            }
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

        public void Add_To_List_Groups(string group_name, string group_description)
        {
            ListViewItem item = new ListViewItem(group_name);
            ListViewItem item_description = new ListViewItem(group_description);

            List_View_Groups.Items.Add(item);   

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

        private void PB_OpenListView_Click(object sender, EventArgs e)
        {
            Open_Form<Group_View>((PictureBox)sender);
            PanelGroups.Visible = true;
        }
    }
}
