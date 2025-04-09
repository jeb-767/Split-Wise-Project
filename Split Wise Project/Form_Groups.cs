using Split_Wise_Project.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Split_Wise_Project
{
    public partial class Form_Groups : Form
    {
        public Usuario usuario = new Usuario();
        public DataAcces.DataAccess d = new DataAcces.DataAccess();
        public List<int> Id_Grupos = new List<int>();
        public List<Grupo> Grupos = new List<Grupo>();
        public Form_Groups()
        {
            InitializeComponent();

            ConfigureDataGridView();

            usuario = Form_Menu.Loged_User;

            foreach (Grupo grupo in d.GetGrupos())
            {
                if (grupo.Estado == "Activado")
                {
                    foreach (Usuario miembro in grupo.GetMiembros())
                    {
                        if (miembro.ID == usuario.ID)
                        {
                            dataGridView1.Rows.Add(grupo.Nombre);
                            Id_Grupos.Add(grupo.ID);
                            Grupos.Add(grupo);
                        }
                    }
                }
            }

        }


        public void Open_Form<my_form>(PictureBox menu_button) where my_form : Form, new()
        {
            //Reb un formulari i busca si el nostre panel ya te el formulari.
            //Si ya el te el mostra i si no el te el creara i el mostrara.
            my_form MyForm = PanelGroups.Controls.OfType<my_form>().FirstOrDefault();

            if (MyForm == null)
            {
                MyForm = new my_form();
                MyForm.TopLevel = false; //Ficara el formulari dins del panel
                MyForm.FormBorderStyle = FormBorderStyle.None;
                MyForm.Dock = DockStyle.Fill;
                PanelGroups.Controls.Add(MyForm);
                MyForm.Show();
                MyForm.BringToFront();
            }
            else
            {
                MyForm.BringToFront();
            }
        }
        private void But_New_Group_Click(object sender, EventArgs e)
        {
            Form new_group = new Form_NewGroup();
            new_group.Show();
        }

        private void PB_Delete_Group_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                foreach (Grupo grupo in Grupos)
                {
                    if(grupo.ID == Id_Grupos[row.Index])
                    {
                        grupo.DeleteGroup(grupo.Nombre);
                        dataGridView1.Rows.Remove(row);
                        break;
                    }
                }
            }
        }
        private void But_New_Group_MouseEnter(object sender, EventArgs e)
        {
            But_New_Group.Image = Properties.Resources.But_New_Group_Hold;
        }

        private void But_New_Group_MouseLeave(object sender, EventArgs e)
        {
            But_New_Group.Image = Properties.Resources.But_New_Group;
        }

        public void Add_To_List_Groups(string group_name, string group_description)
        {
            d.CreateGroup(group_name, group_description, usuario);
            dataGridView1.Rows.Add(group_name);
        }

        public void PB_OpenListView_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if(dataGridView1.SelectedRows.Count > 1)
                {
                    break;
                }
                else
                {
                    Open_Form<Group_View>((PictureBox)sender);
                    PanelGroups.Visible = true;
                }
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
    }
}
