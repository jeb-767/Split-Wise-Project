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
    public partial class Form_NewFriend : Form
    {
        public Form_NewFriend()
        {
            InitializeComponent();
        }
        private void But_Friends_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void But_Friends_Create_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario = Form_Menu.Loged_User;

            Usuario nuevoAmigo = usuario.AddAmigo(TB_Friends_Email.Text);

            Form_Friends Amigos = (Form_Friends)Form_Menu.Panel_Principal_Ref.Controls.OfType<Form_Friends>().FirstOrDefault();
            if (nuevoAmigo !=  null)
            {
                Amigos.Add_Friend(nuevoAmigo.Nombre, nuevoAmigo.Apellidos);
            }
            else
            {
                MessageBox.Show("El amigo no se ha podido añadir, comprueba el correo", "Error al añadir el amigo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
            this.Close();
        }
    }
}
