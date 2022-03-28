using System;
using System.Collections.Generic;
namespace ProyectoETS
{
    class Tratar_Fechas
    {
        public static FechasDif[] MeterFechasLista(int totalFechas, DateTime fecha1, DateTime fecha2)
        {
            OrdenarFechas(ref fecha1, ref fecha2);
            FechasDif[] fechas = new FechasDif[totalFechas];
            DateTime fechaActual = DateTime.Now;
            fechas[0].fecha1 = fecha1;
            fechas[0].fecha2 = fecha2;
            fechas[1].fecha1 = fecha1;
            fechas[1].fecha2 = DateTime.Now;
            fechas[2].fecha1 = fecha2;
            fechas[2].fecha2 = fechaActual;
            return fechas;
        }
        private static void OrdenarFechas(ref DateTime fecha1, ref DateTime fecha2)
        {
            int afterBefore = DateTime.Compare(fecha1, fecha2);
            if (afterBefore > 0)
            {
                DateTime aux = fecha2;
                fecha2 = fecha1;
                fecha1 = aux;
            }
        }
        /// <summary>
        /// Solicita la diferencia en años y dias entre dos fechas, los resultado se devuelve por referencias
        /// </summary>
        /// <param name="fecha1"></param>
        /// <param name="fecha2"></param>
        /// <param name="diferenciaAnhos"></param>
        /// <param name="difDias"></param>
        public static void DiferenciaFechasDadas(ref FechasDif[] fechas)
        {
            for (int count = 0; count < fechas.Length; count++)
            {
                int diferenciaAnhos = CalcularDiferenciaAnhos(fechas[count].fecha1, fechas[count].fecha2);
                fechas[count].difAnhos = diferenciaAnhos;
                fechas[count].difDias = CalcularDiferenciaDias(fechas[count].fecha1, fechas[count].fecha2, fechas[count].fecha1.Year, fechas[count].fecha2.Year);
            }
        }
        private static int CalcularDiferenciaAnhos(DateTime fecha1,DateTime fecha2)
        {
            int anho1 = fecha1.Year;
            int anho2 = fecha2.Year;
            int diferenciaAnhos = anho2 - anho1;
            if (fecha2.Month < fecha1.Month) // si el mes de la segunda fecha (la mayor), es mas pequeño que el de la primera fecha. significa que ese año no ha pasado completo,y restamos 1 al dif año
            {
                diferenciaAnhos += -1;
            }
            return diferenciaAnhos;
        }
        /// <summary>
        /// Se encarga de calcular la diferencia de dias entre dos fechas
        /// </summary>
        /// <param name="fecha1"></param>
        /// <param name="fecha2"></param>
        /// <param name="anho1"></param>
        /// <param name="anho2"></param>
        /// <returns>INT Diferencia dias entre fechas</returns>
        private static int CalcularDiferenciaDias(DateTime fecha1, DateTime fecha2,int anho1,int anho2)
        {
            TimeSpan difFechas = fecha2 - fecha1; //TimeSpan nos permite ver la diferencia entre dos fechas
            int dias = difFechas.Days + SumarDiaBisiesto(anho1,anho2);
            return dias;
        }
        /// <summary>
        /// crear un contador donde se irán sumando los dias (por año bisiesto) que hay que añadir en la diferencia de dias entre fechas
        /// </summary>
        /// <param name="anho1"></param>
        /// <param name="anho2"></param>
        /// <returns>cantidad de dias (por año bisiesto)a sumar</returns>
        private static int SumarDiaBisiesto(int anho1, int anho2)
        {
            const int INICIOBISIESTO = 1582; //Fecha donde empiezan los años bisiestos
            int diasSumar = 0;

            if (anho1 >= INICIOBISIESTO)
            {
                if (anho2 >= INICIOBISIESTO)
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
                    Mensajes.MostrarError("El año : " + anho2.ToString() + " es inferior al año " + INICIOBISIESTO + "\nNo se sumarán dias adicionales, " +
                                           "ya que fechas inferiores a " + INICIOBISIESTO + " no cuentan para ser años bisiestos");
                }
            }
            else
            {
                Mensajes.MostrarError("El año : " + anho1.ToString() + " es inferior al año " + INICIOBISIESTO+ "\nNo se sumarán dias adicionales, " +
                                       "ya que fechas inferiores a "+INICIOBISIESTO+ " no cuentan para ser años bisiestos");
            }
            return diasSumar;
        }
    }
}
