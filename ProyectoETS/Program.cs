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

            if (Pedir_Check_Fecha.ValidarFormatoFecha(ref fecha1,ref fecha1Epoca))
            {
                if (Pedir_Check_Fecha.ValidarFormatoFecha(ref fecha2,ref fecha2Epoca))
                {
                    fechas = Tratar_Fechas.MeterFechasLista(TOTALFECHAS, fecha1, fecha2);
                    Tratar_Fechas.DiferenciaFechasDadas(ref fechas);
                    Mostrado.MostrarDiferencia(fechas);

                }
            }
            Mensajes.MakeSeeYou();
        }
    }
    class Mensajes
    {

        /// <summary>
        /// Funcion de finalización del programa
        /// </summary>
        public static void MakeSeeYou()
        {
            Console.WriteLine("\nPulsa una tecla para finalizar ....");
            Console.ReadKey(true);
        }

        /// <summary>
        /// Funcion del mostrado al usuario.
        /// </summary>
        /// <param name="mensaje"></param>
        public static void MostrarError(string mensaje)
        {
            Console.Clear();
            Console.WriteLine("<<<<<<<<<<ERROR>>>>>>>>>>");
            Console.WriteLine("<<<<<>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine(mensaje);
            Console.WriteLine("<<<<<>>>>>>>>>>>>>>>>>>>>");
            MakeSeeYou();
        }
    }
   
}
