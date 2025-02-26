using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split_Wise_Project.Model
{
    public class Grupo
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Foto { get; set; }
        public string Estado { get; set; }
        List<Usuario> Miembros { get; set; }

        public Grupo()
        {
            Miembros = new List<Usuario>();
        }

        public Grupo(int _ID, string _Nombre, string _Descripcion, string _Foto, string _Estado)
        {
            Miembros = new List<Usuario>();

            this.ID = _ID;
            this.Nombre = _Nombre;
            this.Descripcion = _Descripcion;
            this.Foto = _Foto;
            this.Estado = _Estado;
        }
    }
}
