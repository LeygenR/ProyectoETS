using System;
using System.Globalization;


namespace ProyectoETS
{
    class Pedir_Check_Fecha
    {
        /// <summary>
        /// Función de pedida e introducción de la fecha.
        /// </summary>
        /// <returns>Fecha con el formato de barras. </returns>
        private static string PedirFecha()
        {
            string fecha;
            bool salida = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Según el formato \"dd/MM/yyyy\".");
                Console.Write("Introduzca una/otra fecha de nacimiento: ");
                fecha = Console.ReadLine();
                if(fecha != "")
                {
                    salida = true;
                }
                else
                {
                    Mensajes.MostrarError("No ha introducido nada.");
                }
            }
            while (!salida);
            return (fecha);
        }

        /// <summary>
        /// Comprueba que la fecha está en el formato correcto.
        /// </summary>
        /// <param name="fechaValid"></param>
        /// <returns>Fecha valida para el datetime</returns>
        public static bool ValidarFormatoFecha(ref DateTime fechaValid)
        {
            bool noerror = false;
            string fecha = PedirFecha();
            string formatEs = "dd/MM/yyyy";

            CultureInfo cultureInfoES = new CultureInfo("es-SP");
            if (DateTime.TryParseExact(fecha, formatEs, cultureInfoES, DateTimeStyles.None, out fechaValid))
            {
                Console.WriteLine("\nFecha en el formato correcto");
                Console.WriteLine("\t" + fechaValid.ToShortDateString());
                noerror = true;
            }
            else
            {
                Mensajes.MostrarError("La fecha introducida no está en el formato solicitado");
            }
            Console.ReadKey(true);
            return (noerror);
        }
    }
}
