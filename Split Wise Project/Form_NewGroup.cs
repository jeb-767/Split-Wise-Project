using Microsoft.VisualBasic.ApplicationServices;
using Split_Wise_Project.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Split_Wise_Project
{
    public partial class Form_NewGroup : Form
    {
        public List<Usuario> miembros = new List<Usuario>();
        public Usuario usuario = new Usuario();
        public DataAcces.DataAccess d = new DataAcces.DataAccess();
        public Form_NewGroup()
        {
            InitializeComponent();
            usuario = Form_Menu.Loged_User;
            miembros.Add(usuario);
        }

        private void But_Groups_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void But_Groups_Create_Click(object sender, EventArgs e)
        {
            Form_Groups Grupos = (Form_Groups)Form_Menu.Panel_Principal_Ref.Controls.OfType<Form_Groups>().FirstOrDefault();
            if (Grupos != null)
            {
                foreach (DataGridViewRow Row in dataGridView1.Rows)
                {
                    //miembros.Add(d.GetUsuarios());
                }

            }
            this.Close();
        }

        private void PB_New_Member_MouseEnter(object sender, EventArgs e)
        {
            PB_New_Member.Image = Properties.Resources.But_New_Friend_Hold;
        }

        private void PB_New_Member_MouseLeave(object sender, EventArgs e)
        {
            PB_New_Member.Image = Properties.Resources.But_New_Friend;
        }

        private void PB_New_Icon_MouseEnter(object sender, EventArgs e)
        {
            PB_New_Icon.Image = Properties.Resources.But_New_Photo_Hold;
        }

        private void PB_New_Icon_MouseLeave(object sender, EventArgs e)
        {
            PB_New_Icon.Image = Properties.Resources.But_New_Photo;
        }

        private void PB_New_Member_Click(object sender, EventArgs e)
        {
            Form new_member = new Form_Friends();
            new_member.Show();
        }

        private void PB_New_Icon_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form_Friends Amigos = (Form_Friends)Form_Menu.Panel_Principal_Ref.Controls.OfType<Form_Friends>().FirstOrDefault();
            Amigos.SeleccionarMiembro();
            //miembros.Add(Amigos.SeleccionarMiembro());
            dataGridView1.Rows.Add(Amigos.SeleccionarMiembro().Nombre, Amigos.SeleccionarMiembro().Apellidos);
        }
    }
}
