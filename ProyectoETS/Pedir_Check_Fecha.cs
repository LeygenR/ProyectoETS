using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoETS
{
    class Pedir_Check_Fecha
    {
        public static bool PedirFecha()
        {
            bool salida = false;
            do
            {
                Console.Write("Introduzca una/otra fecha de nacimiento")
            }
            while (!salida);
            return (salida);
        }
    }
}
