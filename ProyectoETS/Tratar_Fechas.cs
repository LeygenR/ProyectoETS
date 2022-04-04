using System;
namespace ProyectoETS
{
    public class Tratar_Fechas
    {
        public static void MeterFechasLista(int totalFechas, ref FechasDif[] fechas)
        {
            DateTime fechaActual = DateTime.Now;
            fechas[1].fecha1 = fechas[0].fecha1;
            fechas[1].fechaEpoca1 = fechas[0].fechaEpoca1;
            fechas[1].fecha2 = fechaActual;
            fechas[1].fechaEpoca2 = "DC";

            fechas[2].fecha1 = fechas[0].fecha2;
            fechas[2].fechaEpoca1 = fechas[0].fechaEpoca2;
            fechas[2].fecha2 = fechaActual;
            fechas[2].fechaEpoca2 = "DC";
        }
        /// <summary>
        /// Solicita la diferencia en años y dias entre dos fechas, los resultado se devuelve por referencias
        /// </summary>
        /// <param name="fecha1"></param>
        /// <param name="fecha2"></param>
        /// <param name="diferenciaAnhos"></param>
        /// <param name="difDias"></param>
        public static void DiferenciaFechasDadas(FechasDif[] fechas)
        {
            int anho1 = 0;
            int anho2 = 0;
            for (int count = 0; count < fechas.Length; count++)
            {
                int diferenciaAnhos = CalcularDiferenciaAnhos(fechas[count].fecha1, fechas[count].fecha2, fechas[count].fechaEpoca1, fechas[count].fechaEpoca2, ref anho1, ref anho2);
                fechas[count].difAnhos = diferenciaAnhos;
                fechas[count].difDias = CalcularDiferenciaDias(fechas[count].fecha1, fechas[count].fecha2, anho1, anho2, fechas[count].fechaEpoca1, fechas[count].fechaEpoca2);
            }
        }
        private static int CalcularDiferenciaAnhos(DateTime fecha1, DateTime fecha2, string fecha1Epoca, string fecha2Epoca, ref int anho1, ref int anho2)
        {
            anho1 = fecha1.Year;
            anho2 = fecha2.Year;
            if (fecha1Epoca.Equals("AC"))
            {
                anho1 = anho1 * (-1);
            }

            if (fecha2Epoca.Equals("AC"))
            {
                anho2 = anho2 * (-1);
            }

            int diferenciaAnhos = anho2 - anho1;
            if (diferenciaAnhos < 0)
            {
                diferenciaAnhos = diferenciaAnhos * (-1);
            }
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
        public static int CalcularDiferenciaDias(DateTime fecha1, DateTime fecha2, int anho1, int anho2, string fecha1Epoca, string fecha2Epoca)
        {
            int dias = 0;

            if ((fecha1Epoca.Equals("AC") && (fecha2Epoca.Equals("DC"))))
            {
                dias = CalcularDiasAC(fecha1, fecha2);
            }
            else
            {
                if ((fecha1Epoca.Equals("DC") && (fecha2Epoca.Equals("AC"))))
                {
                    dias = CalcularDiasAC(fecha2, fecha1);
                }
                else
                {
                    calcularDiasDiff(fecha1, fecha2);
                }
            }

            if (dias < 0)
            {
                dias = dias * (-1);
            }

            int diasTotal = dias + SumarDiaBisiesto(anho1, anho2);
            return diasTotal;
        }
        /// <summary>
        /// crear un contador donde se irán sumando los dias (por año bisiesto) que hay que añadir en la diferencia de dias entre fechas
        /// </summary>
        /// <param name="anho1"></param>
        /// <param name="anho2"></param>
        /// <returns>cantidad de dias (por año bisiesto)a sumar</returns>
        public static int SumarDiaBisiesto(int anho1, int anho2)
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
            }
            return diasSumar;
        }
        public static int CalcularDiasAC(DateTime fechaAC, DateTime fechaDC)
        {

            string fechaCambiar = fechaDC.ToShortDateString();
            string fechaArreglada2 = "";
            for (int count = 0; count < fechaCambiar.Length - 4; count++)
            {
                fechaArreglada2 += fechaCambiar[count];
            }

            string añoAdicional = Convert.ToString((fechaDC.Year) + fechaAC.Year * 2);
            string año = "";
            for (int count = 0; count < 4 - (añoAdicional.ToString().Length); count++)
            {
                año += "0";
            }

            año += añoAdicional.ToString();
            fechaArreglada2 += año;

            int dias = calcularDiasDiff(fechaAC, Convert.ToDateTime(fechaArreglada2));

            return dias;
        }

        public static int calcularDiasDiff(DateTime fecha1, DateTime fecha2)
        {
            TimeSpan difFechas;

            difFechas = fecha1 - fecha2;
            int dias = difFechas.Days;
            return dias;
        }
    }
}
