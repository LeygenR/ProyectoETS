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
        public string fechaEpoca1;
        public string fechaEpoca2;
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
            const int TOTALFECHAS = 3;
            FechasDif[] fechas = new FechasDif[TOTALFECHAS];

            if (Pedir_Check_Fecha.ValidarFormatoFecha(ref fechas[0].fecha1, ref fechas[0].fechaEpoca1))
            {
                if (Pedir_Check_Fecha.ValidarFormatoFecha(ref fechas[0].fecha2, ref fechas[0].fechaEpoca2))
                {
                    Tratar_Fechas.MeterFechasLista(TOTALFECHAS,ref fechas);
                    Tratar_Fechas.DiferenciaFechasDadas(fechas);
                    Mostrado.MostrarDiferencia(fechas);
                }
            }
            Mostrado.MakeSeeYou();
        }
    }
}
