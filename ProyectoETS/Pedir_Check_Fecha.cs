using System;
using System.Globalization;
using System.Collections.Generic;


namespace ProyectoETS
{
    class Pedir_Check_Fecha
    {
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
        public static bool ValidarFormatoFecha(ref DateTime fechaValid)
        {
            bool noerror = false;
            string fecha = PedirFecha();
            string formatEs = "dd/MM/yyyy";

            CultureInfo cultureInfoES = new CultureInfo("es-SP");
            if(DateTime.TryParseExact(fecha, formatEs, cultureInfoES, DateTimeStyles.None, out fechaValid))
            {
                Console.WriteLine("\nFecha en el formato correcto");
                Console.WriteLine("\t"+fechaValid.ToShortDateString());
                noerror=true;
            }
            else
            {
                Mensajes.MostrarError("La fecha introducida no está en el formato solicitado");
            }
            Console.ReadKey(true);
            return(noerror);
        }
        public static void CompararAnho(ref int anho1, ref int anho2)
        {

        }
    }
}
