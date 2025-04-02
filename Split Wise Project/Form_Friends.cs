using Split_Wise_Project.Model;
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
    public partial class Form_Friends : Form
    {
        public static StyledListView listView;
        public Form_Friends()
        {
            InitializeComponent();

            Usuario usuario = new Usuario();
            usuario = Form_Menu.Loged_User;

            listView = new StyledListView();
            listView.Size = new Size(330, 254);
            listView.Location = new Point(0, 0);

            this.Controls.Add(listView);

            foreach (Usuario amigo in usuario.amigos)
            {
                listView.Items.Add(new ListViewItem(new[] { amigo.Nombre, amigo.Apellidos }));
            }
            

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

        public void Add_To_List_Friends(string nombre, string apellidos)
        {

            listView.Items.Add(new ListViewItem(new[] { nombre, apellidos }));
        }

        private void But_Delete_Friend_Click(object sender, EventArgs e)
        {
            listView.Items[0].Remove();
          
        }
    }
}
