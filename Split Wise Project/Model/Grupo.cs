using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Split_Wise_Project.Model
{
    public class Grupo
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Foto { get; set; }
        public string Estado { get; set; }
        public List<Usuario> Miembros { get; set; }
        public List<Gasto> gastos { get; set; }
        List<Registro> Registros { get; set; }

        public Grupo()
        {
            Miembros = new List<Usuario>();
            Registros = new List<Registro>();
            gastos = new List<Gasto>();
        }

        public Grupo(int _ID, string _Nombre, string _Descripcion, string _Foto, string _Estado)
        {
            Miembros = new List<Usuario>();
            Registros = new List<Registro>();
            gastos = new List<Gasto>();

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

        public void AddMiembro(string Email)
        {
            DataAcces.DataAccess d = new DataAcces.DataAccess();
            d.AddMiembroGrupo(this, Email);
        }

        public void AddGasto(string Email_Usuarios, int cantidad, string nombre)
        {
            DataAcces.DataAccess d = new DataAcces.DataAccess();
            d.AddGasto(this, Email_Usuarios, cantidad, nombre);
        }

        public void AddRegistro(string Nombre, string Accion)
        {
            DataAcces.DataAccess d = new DataAcces.DataAccess();
            d.AddRegistros(this, Nombre, Accion);
        }

        public void DeleteGasto(string Nombre)
        {
            DataAcces.DataAccess d = new DataAcces.DataAccess();
            d.DeleteGasto(this, Nombre);
        }
        public void DeleteGroup(string name)
        {
            DataAcces.DataAccess d = new DataAcces.DataAccess();
            d.DeleteGrupo(name);
        }

    }
}
