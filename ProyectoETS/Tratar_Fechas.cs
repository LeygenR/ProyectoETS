using System;

namespace ProyectoETS
{
    class Tratar_Fechas
    {
        
        public static void DiferenciaAñosYdias(DateTime fecha1, DateTime fecha2, ref int diferenciaAnhos, ref int difDias)
        {
            int anho1 = fecha1.Year;
            int anho2 = fecha2.Year;
            diferenciaAnhos = anho2-anho1 ;
            difDias = DiferenciaDias(fecha1,fecha2,anho1, anho2);
        }
        private static int DiferenciaDias(DateTime fecha1, DateTime fecha2,int anho1,int anho2)
        {
            TimeSpan difFechas = fecha2 - fecha1;
            int dias = difFechas.Days + sumarDiaBisiesto(anho1,anho2);
            return dias;
        }
        private static int sumarDiaBisiesto(int anho1, int anho2)
        {
            const int INICIOBISIESTO = 1582;
            int diasSumar = 0;

            if (anho1 > INICIOBISIESTO)
            {
                if (anho2 > INICIOBISIESTO)
                {

                    for (int year = anho1; anho1 <= anho2; anho1++)
                    {
                        if (DateTime.IsLeapYear(anho1)) //contamos los años bisiestos
                        {
                            diasSumar++;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("El año: {0} es inferior al año {1}", anho2, INICIOBISIESTO);
                    Console.WriteLine("No se sumarán dias adicionales, ya que fechas inferiores a {0} no cuentan para ser años bisiestos", INICIOBISIESTO);
                }
            }
            else
            {
                Console.WriteLine("El año: {0} es inferior al año {1}", anho1, INICIOBISIESTO);
                Console.WriteLine("No se sumarán dias adicionales, ya que fechas inferiores a {0} no cuentan para ser años bisiestos", INICIOBISIESTO);
            }
            return diasSumar;
        }
    }
}
