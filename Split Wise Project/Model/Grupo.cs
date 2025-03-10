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

        List<Registro> Registros { get; set; }

        public Grupo()
        {
            Miembros = new List<Usuario>();
            Registros = new List<Registro>();
        }

        public Grupo(int _ID, string _Nombre, string _Descripcion, string _Foto, string _Estado)
        {
            Miembros = new List<Usuario>();
            Registros = new List<Registro>();

            this.ID = _ID;
            this.Nombre = _Nombre;
            this.Descripcion = _Descripcion;
            this.Foto = _Foto;
            this.Estado = _Estado;
        }

        public List<Usuario> GetMiembros()
        {
            DataAcces.DataAccess d = new DataAcces.DataAccess();
            Miembros = d.GetMiembros(ID);
            return Miembros;
        }

        public List<Registro> GetRegistros()
        {
            DataAcces.DataAccess d = new DataAcces.DataAccess();
            Registros = d.GetRegistros(ID);
            return Registros;
        }
       
    }
}
