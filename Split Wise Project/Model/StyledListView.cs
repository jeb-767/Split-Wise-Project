using System.Drawing;
using System.Windows.Forms;

public class StyledListView : ListView
{
    public StyledListView()
    {
        // Configurar propiedades básicas
        this.View = View.Details;
        this.FullRowSelect = true;
        this.GridLines = false;
        this.BorderStyle = BorderStyle.None;
        this.BackColor = Color.White;
        this.ForeColor = Color.Black;
        this.Font = new Font("Segoe UI", 10);
        this.OwnerDraw = true;
        this.DoubleBuffering(true);

        // Configurar columnas
        this.Columns.Add("Nombre", 150);
        this.Columns.Add("Apellidos", 180);

        // Estilizar encabezados
        this.HeaderStyle = ColumnHeaderStyle.Nonclickable;

        // Eventos de dibujo
        this.DrawColumnHeader += ListView_DrawColumnHeader;
        this.DrawItem += ListView_DrawItem;
        this.DrawSubItem += ListView_DrawSubItem;
    }

    private void ListView_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
    {
        // Dibujar encabezado con fondo negro y texto blanco
        e.Graphics.FillRectangle(Brushes.Black, e.Bounds);
        e.Graphics.DrawString(e.Header.Text, this.Font, Brushes.White, e.Bounds.Left + 5, e.Bounds.Top + 3);
    }

    private void ListView_DrawItem(object sender, DrawListViewItemEventArgs e)
    {
        // Fondo alternado para las filas
        var bgColor = e.ItemIndex % 2 == 0 ? Color.White : Color.LightGray;
        e.Graphics.FillRectangle(new SolidBrush(bgColor), e.Bounds);

        // Dibujar borde inferior
        e.Graphics.DrawRectangle(Pens.Black, new Rectangle(e.Bounds.Left, e.Bounds.Bottom - 1, e.Bounds.Width, 1));
    }

    private void ListView_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
    {
        // Dibujar texto de subitems
        TextRenderer.DrawText(e.Graphics, e.SubItem.Text, this.Font, e.Bounds, Color.Black, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
    }

    // Método para habilitar Double Buffering
    private void DoubleBuffering(bool enable)
    {
        typeof(Control).GetProperty("DoubleBuffered",
            System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
            .SetValue(this, enable, null);
    }
}