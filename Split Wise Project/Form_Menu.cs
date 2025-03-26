using Org.BouncyCastle.Crypto.Macs;
using Split_Wise_Project.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Split_Wise_Project
{
    public partial class Form_Menu : Form
    {
        public int Pulse_Button = 0;
        public static Panel Panel_Principal_Ref;
        public Form_Menu()
        {
            InitializeComponent();
            Panel_Principal_Ref = Panel_Principal;
            DataAcces.DataAccess d= new DataAcces.DataAccess();
            Usuario u= d.GetUsuarios()[1];
            Grupo f = d.GetGrupos()[1];
            f.DeleteGroup("Paella");
        }
   
        public void Open_Form<my_form>(PictureBox menu_button) where my_form : Form, new()
        {
            //Reb un formulari i busca si el nostre panel ya te el formulari.
            //Si ya el te el mostra i si no el te el creara i el mostrara.
            my_form MyForm = Panel_Principal.Controls.OfType<my_form>().FirstOrDefault();

            if (MyForm == null)
            {
                MyForm = new my_form();
                MyForm.TopLevel = false; //Ficara el formulari dins del panel
                MyForm.FormBorderStyle = FormBorderStyle.None;
                MyForm.Dock = DockStyle.Fill;
                Panel_Principal.Controls.Add(MyForm);
                MyForm.Show();
                MyForm.BringToFront();
            }
            else
            {
                MyForm.BringToFront();
            }
        }

        private void But_Groups_Click(object sender, EventArgs e)
        {
            Open_Form<Form_Groups>((PictureBox)sender);
            But_Groups.BackColor = Color.LightGray;
            But_Friends.BackColor = Color.Transparent;
            But_Hist.BackColor = Color.Transparent;

        }

        private void But_Friends_Click(object sender, EventArgs e)
        {
            Open_Form<Form_Friends>((PictureBox)sender);
            But_Groups.BackColor = Color.Transparent;
            But_Friends.BackColor = Color.LightGray;
            But_Hist.BackColor = Color.Transparent;
        }

        private void But_Hist_Click(object sender, EventArgs e)
        {
            Open_Form<Form_Hist>((PictureBox)sender);
            But_Groups.BackColor = Color.Transparent;
            But_Friends.BackColor = Color.Transparent;
            But_Hist.BackColor = Color.LightGray;
        }

        private void But_Groups_DragEnter(object sender, DragEventArgs e)
        {
            But_Groups.Image = Properties.Resources.But_Groups_Hold;
        }

        private void But_Groups_MouseEnter(object sender, EventArgs e)
        {
            But_Groups.Image = Properties.Resources.But_Groups_Hold;
        }

        private void But_Groups_MouseLeave(object sender, EventArgs e)
        {
            But_Groups.Image = Properties.Resources.But_Groups;
        }

        private void But_Friends_MouseEnter(object sender, EventArgs e)
        {
            But_Friends.Image = Properties.Resources.But_Friends_Hold;
        }

        private void But_Friends_MouseLeave(object sender, EventArgs e)
        {
            But_Friends.Image = Properties.Resources.But_Friends;
        }

        private void But_Hist_MouseEnter(object sender, EventArgs e)
        {
            But_Hist.Image = Properties.Resources.But_Hist_Hold;
        }

        private void But_Hist_MouseLeave(object sender, EventArgs e)
        {
            But_Hist.Image = Properties.Resources.But_Hist;
        }
    }
}
