using Split_Wise_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Split_Wise_Project.Controller
{
    public class Controlador
    {
        DataAcces.DataAccess d = new DataAcces.DataAccess();
        Grupo grupo = new Grupo();
        public Controlador() { }
        public void AlgoritmoPago()
        {
            List<float> Gastos_Usuarios = new List<float>();
            List<Usuario> Miembros = new List<Usuario>();
            grupo = d.GetGrupos()[1];
            float Total_Gastos = 0;
            int Contador = 0;
            foreach (Gasto gr in d.GetGastos(grupo.ID))
            {
                if(gr.Estado == "Pendiente")
                {
                    Total_Gastos += gr.Cantidad;
                }
                
            }
            foreach(Usuario miembro in grupo.GetMiembros())
            {
                Miembros.Add(miembro);
                Gastos_Usuarios.Add(0);
                foreach (Gasto gr in d.GetGastosPersinaGrupo(grupo.ID, miembro.ID))
                {
                    Gastos_Usuarios[miembro.ID - 1] += gr.Cantidad;
                }
                Contador += 1;
            }
        }
    }
}
    
