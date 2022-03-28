using System;
using System.Collections.Generic;
namespace ProyectoETS
{
    public struct FechasDif
    {
        public DateTime fecha1;
        public DateTime fecha2;
        public int difAnhos;
        public int difDias;
    }
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha1 =  new DateTime();
            DateTime fecha2 =  new DateTime();
            const int TOTALFECHAS = 3;
            FechasDif[] fechas = new FechasDif[TOTALFECHAS];
            if (Pedir_Check_Fecha.ValidarFormatoFecha(ref fecha1))
            {
                if(Pedir_Check_Fecha.ValidarFormatoFecha(ref fecha2))
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
        public static void MakeSeeYou()
        {
            Console.WriteLine("\nPulsa una tecla para finalizar ....");
            Console.ReadKey(true);
        }

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
