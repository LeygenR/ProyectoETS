using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoETS
{
    class Mostrado
    {
        public static void MostrarDiferencia(FechasDif[]fechas)
        {
            for (int count = 0 ; count < fechas.Length;count++)
            {
                Console.WriteLine(fechas[count].fecha1.Date.ToShortDateString().PadRight(15) + fechas[count].fecha2.Date.ToShortDateString().PadRight(15) + 
                 "Diferencia Años : ".PadRight(20) + fechas[count].difAnhos.ToString().PadRight(30) + "Diferencia Dias : ".PadRight(20) + fechas[count].difDias);
            }
            
        }
    }
}
