using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split_Wise_Project.Model
{
    public class Gasto
    {
        public int ID { get; set; }
        public int usuario { get; set; }
        public int grupo { get; set; }
        public float Cantidad { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public List<Usuario> Implicados { get; set; }

        public Gasto()
        {
            Implicados = new List<Usuario>();
        }

        public Gasto(int _ID, int _Usuario, int _Grupo , float _Cantidad, string _Nombre , string _Estado)
        {
            Implicados = new List<Usuario>();

            this.ID = _ID;
            this.usuario = _Usuario;
            this.grupo = _Grupo;
            this.Cantidad = _Cantidad;
            this.Nombre = _Nombre;
            this.Estado = _Estado;
        }
        
    }
}
