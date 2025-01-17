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
            this.Close();
        }
    }
}
