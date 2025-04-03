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
            int index = usuario.amigos.Count();
            

            Form_Friends d = new Form_Friends();
            if(nuevoAmigo !=  null)
            {
                d.Add_Friend(nuevoAmigo.Nombre, nuevoAmigo.Apellidos);
            }
            else
            {
                MessageBox.Show("Error", "Error Title", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
            this.Close();
        }
    }
}
