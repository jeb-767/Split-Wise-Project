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
        public int Gasto {  get; set; }
        public string Accion { get; set; }

        public Registro()
        {
        }

        public Registro(int _ID, int _Gasto , string _Accion)
        {
            this.ID = _ID;
            this.Gasto = _Gasto;
            this.Accion = _Accion;
        }

    }
}
