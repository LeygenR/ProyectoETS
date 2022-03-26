using System;

namespace ProyectoETS
{
    class Tratar_Fechas
    {
        public static int sumarDiaBisiesto()
        {
            string fecha1 = "10/10/1920";
            string fecha2 = "19/12/2001";

            string[] fechaSeparada = fecha1.Split('/');

            int año1 = Convert.ToInt32(fechaSeparada[2]);

            string[] fechaSeparada2 = fecha2.Split('/');
            int año2 = Convert.ToInt32(fechaSeparada2[2]);

            int diasSumar = 0;

            for (int year = año1; año1 <= año2; año1++)
            {
                if (DateTime.IsLeapYear(año1))
                {
                    diasSumar++;
                }
            }
            return diasSumar;
        }
    }
}
