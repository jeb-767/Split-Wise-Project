using System.Drawing;
using System.Windows.Forms;

public class StyledListView : ListView
{
    public StyledListView()
    {
        // Configurar propiedades básicas
        this.View = View.Details;
        this.FullRowSelect = true;
        this.HideSelection = false;
        this.GridLines = false;
        this.BorderStyle = BorderStyle.None;
        this.BackColor = Color.White;
        this.ForeColor = Color.Black;
        this.Font = new Font("Segoe UI", 10);
        this.OwnerDraw = true;
        

        // Configurar columnas
        this.Columns.Add("Nombre", 150);
        this.Columns.Add("Apellidos", 180);

        // Estilizar encabezados
        this.HeaderStyle = ColumnHeaderStyle.Nonclickable;

        // Eventos de dibujo
        
        this.DrawItem += ListView_DrawItem;
        this.DrawSubItem += ListView_DrawSubItem;

    }

    protected override void OnKeyDown(KeyEventArgs e)
    {
        base.OnKeyDown(e);
        // Permitir selección múltiple con Ctrl y rangos con Shift
        if (e.Control && e.KeyCode == Keys.A)
        {
            foreach (ListViewItem item in Items)
            {
                item.Selected = true;
            }
        }
    }

    // Modificar el método de dibujo de items para incluir selección
    private void ListView_DrawItem(object sender, DrawListViewItemEventArgs e)
    {
        // Determinar colores según estado
        Color bgColor, textColor;

        if (e.Item.Selected)
        {
            bgColor = Color.FromArgb(40, 40, 40); // Gris oscuro para selección
            textColor = Color.White;
        }
        else
        {
            bgColor = e.ItemIndex % 2 == 0 ? Color.White : Color.LightGray;
            textColor = Color.Black;
        }

        // Dibujar fondo
        e.Graphics.FillRectangle(new SolidBrush(bgColor), e.Bounds);

        // Dibujar texto del primer ítem
        TextRenderer.DrawText(e.Graphics, e.Item.Text, this.Font,
            new Rectangle(e.Bounds.Left + 5, e.Bounds.Top, e.Bounds.Width, e.Bounds.Height),
            textColor,
            TextFormatFlags.Left | TextFormatFlags.VerticalCenter);

        // Dibujar borde inferior
        e.Graphics.DrawLine(Pens.Black,
            e.Bounds.Left, e.Bounds.Bottom - 1,
            e.Bounds.Right, e.Bounds.Bottom - 1);
    }

    // Modificar el dibujo de subitems para selección
    private void ListView_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
    {
        Color textColor = e.Item.Selected ? Color.White : Color.Black;

        TextRenderer.DrawText(e.Graphics, e.SubItem.Text, this.Font, e.Bounds,
            textColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
    }

    // Nuevo método para selección programática
    public void SelectItems(params int[] indices)
    {
        BeginUpdate();
        try
        {
            foreach (int index in indices)
            {
                if (index >= 0 && index < Items.Count)
                {
                    Items[index].Selected = true;
                }
            }
        }
        finally
        {
            EndUpdate();
        }
    }

    // Nuevo método para deseleccionar todo
    public void ClearSelection()
    {
        SelectedItems.Clear();
    }
}