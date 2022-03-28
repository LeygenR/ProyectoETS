using System;

namespace ProyectoETS
{
    class Mostrado
    {
        public static void MostrarDiferencia(FechasDif[] fechas)
        {
            Console.Clear();
            for (int count = 0; count < fechas.Length; count++)
            {
                Console.WriteLine(fechas[count].fecha1.Date.ToShortDateString().PadRight(15) + fechas[count].fecha2.Date.ToShortDateString().PadRight(15) +
                 "Diferencia Años: ".PadRight(10) + fechas[count].difAnhos.ToString().PadRight(10) + "Diferencia Dias: ".PadRight(10) + fechas[count].difDias);
            }

        }
    }
}
