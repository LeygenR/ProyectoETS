using System;

namespace ProyectoETS
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha1 =  new DateTime();
            DateTime fecha2 =  new DateTime();
            if(Pedir_Check_Fecha.ValidarFormatoFecha(ref fecha1))
            {
                if(Pedir_Check_Fecha.ValidarFormatoFecha(ref fecha2))
                {
                    int diferenciaAnhos = 0;
                    int difDias = 0;
                    Tratar_Fechas.DiferenciaAñosYdias(fecha1,fecha2, ref diferenciaAnhos, ref difDias)
                }
            }
            Mensajes.MakeSeeYou();
        }
    }
    class Mensajes
    {
        public static void MakeSeeYou()
        {
            Console.Write("\nPulsa una tecla para finalizar ....");
            Console.ReadKey(true);
        }

        public static void MostrarError(string mensaje)
        {
            Console.Clear();
            Console.WriteLine("<<<<<<<<<<ERROR>>>>>>>>>>");
            Console.WriteLine("<<<<<>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine(mensaje);
            Console.WriteLine("<<<<<>>>>>>>>>>>>>>>>>>>>");
            Console.Write("\nPulsa una tecla para finalizar ...");
            Console.ReadKey(true);
        }
    }
}
