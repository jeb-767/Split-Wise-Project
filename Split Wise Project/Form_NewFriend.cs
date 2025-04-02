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
        
            StyledListView list = new StyledListView();
            list = Form_Friends.listView;

            Usuario usuario = new Usuario();
            usuario = Form_Menu.Loged_User;

            usuario.AddAmigo(TB_Friends_Email.Text);
            int index = usuario.amigos.Count();
            list.Items.Add(new ListViewItem(new[] { usuario.amigos[index - 1].Nombre , usuario.amigos[index - 1].Apellidos}));

            
            this.Close();
        }
    }
}
