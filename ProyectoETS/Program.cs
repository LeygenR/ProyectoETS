using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoETS
{
    class Program
    {
        static void Main(string[] args)
        {
            string fecha1 = "";
            if(Pedir_Check_Fecha.PedirFecha(ref fecha1))
            {
                DateTime.Parse(fecha1);
            }
            
        }
    }
}
