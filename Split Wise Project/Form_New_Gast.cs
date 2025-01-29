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
    public partial class Form_New_Gast : Form
    {
        public Form_New_Gast()
        {
            InitializeComponent();
        }

        private void But_Add_Gast_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void But_Gast_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
