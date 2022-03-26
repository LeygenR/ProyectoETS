using System;

namespace ProyectoETS
{
    class Pedir_Check_Fecha
    {
        public static bool PedirFecha(ref string fecha)
        {
            bool salida = false;
            do
            {

                Console.Write("Introduzca una/otra fecha de nacimiento");

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
            return (salida);
        }
    }
}
