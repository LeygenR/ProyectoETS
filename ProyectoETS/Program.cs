using System;

namespace ProyectoETS
{
    class Program
    {
        static void Main(string[] args)
        {
            bool noerror = true;
            string fecha1 = "10/10/-200";
            string fecha2 = "19/12/50";
            int diasAdicionakes = Tratar_Fechas.DiferenciaAños(ref noerror, fecha1, fecha2);
            if (noerror)
            {

            }
            if (Pedir_Check_Fecha.PedirFecha(ref fecha1))
            {
                DateTime.Parse(fecha1);
            }

        }
    }
}
