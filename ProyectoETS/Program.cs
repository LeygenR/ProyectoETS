using System;
namespace ProyectoETS
{
    /// <summary>
    /// Estructura de fechas y DateTime;
    /// </summary>
    public struct FechasDif
    {
        public DateTime fecha1;
        public DateTime fecha2;
        public int difAnhos;
        public int difDias;
    }
    /*
     * Programa que pide 2 fechas, pueden ser antes o despues de cristo, y se calculara la diferencia de ambas fechas en dias y años
     * Además se calculada la diferencia de dias y años entre las fechas dadas y la actual.
    */
    public class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha1 = new DateTime();
            DateTime fecha2 = new DateTime();
            string fecha1Epoca = "";
            string fecha2Epoca = "";
            const int TOTALFECHAS = 3;
            FechasDif[] fechas = new FechasDif[TOTALFECHAS];

            if (Pedir_Check_Fecha.ValidarFormatoFecha(ref fecha1, ref fecha1Epoca))
            {
                if (Pedir_Check_Fecha.ValidarFormatoFecha(ref fecha2, ref fecha2Epoca))
                {
                    fechas = Tratar_Fechas.MeterFechasLista(TOTALFECHAS, fecha1, fecha2);
                    Tratar_Fechas.DiferenciaFechasDadas(ref fechas, fecha1Epoca, fecha2Epoca);
                    Mostrado.MostrarDiferencia(fechas);

                }
            }
            Mostrado.MakeSeeYou();
        }
    }
}
