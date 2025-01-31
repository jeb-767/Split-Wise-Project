using Microsoft.VisualBasic.ApplicationServices;
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

        public Form_NewGroup()
        {
            InitializeComponent();
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
                Grupos.Add_To_List_Groups(TB_NewGroup_Name.Text, TB_NewGroup_Description.Text);
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
    }
}
