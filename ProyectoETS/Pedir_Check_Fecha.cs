using System;
using System.Globalization;

namespace ProyectoETS
{
    class Pedir_Check_Fecha
    {
        public static string PedirFecha()
        {
            bool salida = false;
            string fecha = "";

            do
            {
                Console.WriteLine("Según el formato \"dd/mm/yyyy\".");
                Console.Write("Introduzca una/otra fecha de nacimiento: ");

                fecha = Console.ReadLine();

                if (fecha != "")
                {
                    
                    salida = true;

                }
                else
                {
                    Console.WriteLine("No ha introducido nada.");
                    Console.WriteLine("Por favor, escriba la fecha.");
                    Console.ReadKey(true);
                }
            }
            while (!salida);

            return fecha;
        }

        public static void ValidarFecha()
        {
            string fecha = PedirFecha();

            CultureInfo cultureInfoES = new CultureInfo("es-SP");

            DateTime FechaValida = DateTime.Parse(fecha,cultureInfoES);

        }
    }
}
