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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Split_Wise_Project
{
    public partial class Form_Friends : Form
    {
        
        public Usuario usuario = new Usuario();
       
        public Form_Friends()
        {
            InitializeComponent();

            usuario = Form_Menu.Loged_User;

            ConfigureDataGridView();

            foreach (Usuario amigo in usuario.amigos)
            {
                dataGridView1.Rows.Add(amigo.Nombre, amigo.Apellidos);
            }
        }

        private void ConfigureDataGridView()
        {
            // Configuración básica del DataGridView
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.FixedSingle;
            dataGridView1.GridColor = Color.FromArgb(240, 240, 240);
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Black;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;

            // Eliminar fila vacía al final
            dataGridView1.AllowUserToAddRows = false;

            // Configurar columnas
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Apellidos", "Apellidos");

            // Estilo de encabezados de columna
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dataGridView1.ColumnHeadersHeight = 30;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Orange;
            dataGridView1.AlternatingRowsDefaultCellStyle.ForeColor = Color.Orange;

            // Estilo de filas
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            dataGridView1.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.RowTemplate.Height = 25;

            // Ajuste de columnas
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.DefaultCellStyle.Padding = new Padding(5);
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
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

        private void But_Delete_Friend_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                usuario.DeleteFriend(usuario.amigos[row.Index].Correo);
                dataGridView1.Rows.RemoveAt(row.Index);
            }
        }

        public void Add_Friend(string nombre , string apellidos)
        {
            dataGridView1.Rows.Add(nombre, apellidos);
        }
    }
}
