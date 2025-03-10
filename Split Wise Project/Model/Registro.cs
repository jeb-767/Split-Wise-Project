using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split_Wise_Project.Model
{
    public class Registro
    {
        public int ID { get; set; }
        public int usuario { get; set; }
        public int grupo { get; set; }
        public string Accion { get; set; }

        public Registro()
        {
        }

        public Registro(int _ID, int _usuario , int _grupo , string _Accion)
        {
            this.ID = _ID;
            this.usuario = _usuario;
            this.grupo = _grupo;
            this.Accion = _Accion;
        }

    }
}
