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
                if (fecha != "")
                {
                    salida = true;
                }
                else
                {
                    Mostrado.MostrarError("No ha introducido nada.");
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
        public static bool ValidarFormatoFecha(ref DateTime fechaValid, ref string fechaEpoca)
        {
            bool noerror = false;
            string fecha = PedirFecha();
            fechaEpoca = PedirEpoca();
            string formatEs = "dd/MM/yyyy";

            CultureInfo cultureInfoES = new CultureInfo("es-SP");
            if (DateTime.TryParseExact(fecha, formatEs, cultureInfoES, DateTimeStyles.None, out fechaValid))
            {
                Console.WriteLine("\nFecha en el formato correcto");
                Console.WriteLine("\t" + fechaValid.ToShortDateString() + " " + fechaEpoca);
                noerror = true;
            }
            else
            {
                Mostrado.MostrarError("La fecha introducida no está en el formato solicitado");
            }
            Console.ReadKey(true);
            return (noerror);
        }
        /// <summary>
        /// pedimos al usuario si la fecha es AC o DC
        /// </summary>
        /// <returns>AC || DC</returns>
        public static string PedirEpoca()
        {
            string epoca;
            bool valid = false;
            do
            {
                Console.WriteLine("Indique con AC o DC la epoca de la fecha");
                epoca = Console.ReadLine().ToUpper().Trim();
                if ((epoca.Equals("AC")) || epoca.Equals("DC"))
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Debe indicar la epoca de la fecha con AD o DC...");
                    Console.ReadKey();
                }
            }
            while (!valid);
            return epoca;
        }
    }
}
