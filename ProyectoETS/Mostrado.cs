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
